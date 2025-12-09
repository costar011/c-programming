"""
YOLOv8 추론 스크립트
사용법: python inference.py <model_path> <input_path> <output_path>
이미지 및 비디오 파일을 지원합니다.
"""
import sys
import os
from pathlib import Path

try:
    from ultralytics import YOLO
    import cv2
except ImportError:
    print("ultralytics가 설치되지 않았습니다. 'pip install ultralytics'를 실행하세요.")
    sys.exit(1)

def is_video_file(file_path):
    """파일이 비디오 파일인지 확인"""
    video_extensions = {'.mp4', '.avi', '.mov', '.mkv', '.wmv', '.flv', '.webm', '.m4v'}
    return Path(file_path).suffix.lower() in video_extensions

def main():
    if len(sys.argv) != 4:
        print("사용법: python inference.py <model_path> <input_path> <output_path>")
        sys.exit(1)
    
    model_path = sys.argv[1]
    input_path = sys.argv[2]
    output_path = sys.argv[3]
    
    # 경로 확인
    if not os.path.exists(model_path):
        print(f"오류: 모델 파일을 찾을 수 없습니다: {model_path}")
        sys.exit(1)
    
    if not os.path.exists(input_path):
        print(f"오류: 입력 파일을 찾을 수 없습니다: {input_path}")
        sys.exit(1)
    
    # 출력 디렉토리 생성
    output_dir = os.path.dirname(output_path)
    if output_dir and not os.path.exists(output_dir):
        os.makedirs(output_dir, exist_ok=True)
    
    try:
        # 모델 로드
        model = YOLO(model_path)
        
        # 비디오 파일인지 확인
        is_video = is_video_file(input_path)
        
        if is_video:
            # 비디오 처리
            print(f"비디오 처리 중: {input_path}")
            
            # 비디오 정보 가져오기
            cap = cv2.VideoCapture(input_path)
            total_frames = int(cap.get(cv2.CAP_PROP_FRAME_COUNT))
            cap.release()
            
            if total_frames == 0:
                print("오류: 비디오 프레임을 읽을 수 없습니다.")
                sys.exit(1)
            
            print(f"PROGRESS:0")  # 시작
            sys.stdout.flush()
            
            # 스트림 모드로 비디오 처리
            results = model.predict(
                source=input_path,
                conf=0.25,
                save=True,
                save_txt=False,
                show=False,
                project=output_dir,
                name=Path(output_path).stem,
                stream=True
            )
            
            # 스트림 결과 처리 및 진행률 업데이트
            frame_count = 0
            for result in results:
                frame_count += 1
                progress = int((frame_count / total_frames) * 100)
                progress = min(99, progress)  # 100%는 완료 후에 표시
                print(f"PROGRESS:{progress}")
                sys.stdout.flush()
            
            print(f"PROGRESS:100")  # 완료
            sys.stdout.flush()
            
            # 비디오 결과 파일 찾기
            result_dir = os.path.join(output_dir, Path(output_path).stem)
            if os.path.exists(result_dir):
                # 결과 비디오 파일 찾기
                for file in os.listdir(result_dir):
                    if file.endswith(('.mp4', '.avi', '.mov', '.mkv')):
                        result_file = os.path.join(result_dir, file)
                        # 최종 출력 경로로 복사
                        import shutil
                        shutil.copy2(result_file, output_path)
                        print(f"결과 비디오가 저장되었습니다: {output_path}")
                        break
                else:
                    print(f"오류: 결과 비디오 파일을 찾을 수 없습니다.")
                    sys.exit(1)
            else:
                print(f"오류: 결과 디렉토리를 찾을 수 없습니다: {result_dir}")
                sys.exit(1)
        else:
            # 이미지 처리
            print(f"이미지 처리 중: {input_path}")
            print(f"PROGRESS:0")  # 시작
            sys.stdout.flush()
            
            results = model.predict(
                source=input_path,
                conf=0.25,
                save=False,
                show=False
            )
            
            print(f"PROGRESS:50")  # 처리 중
            sys.stdout.flush()
            
            # 결과 이미지 저장
            if len(results) > 0:
                result = results[0]
                result.save(output_path)
                print(f"PROGRESS:100")  # 완료
                sys.stdout.flush()
                print(f"결과 이미지가 저장되었습니다: {output_path}")
            else:
                print("오류: 추론 결과가 없습니다.")
                sys.exit(1)
            
    except Exception as e:
        print(f"오류 발생: {str(e)}")
        import traceback
        traceback.print_exc()
        sys.exit(1)

if __name__ == "__main__":
    main()

