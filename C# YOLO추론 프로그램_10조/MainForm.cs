using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YoloDetectionGUI
{
    public partial class MainForm : Form
    {
        private Panel imageDropPanel;
        private Label dropLabel;
        private ListView resultListView;
        private Button selectImageButton;
        private Label modelPathLabel;
        private ProgressBar progressBar;
        private Label progressLabel;
        private string outputFolder = Path.Combine(Application.StartupPath, "detection_results");
        private string selectedModelPath;

        public MainForm()
        {
            // 모델 경로를 여러 위치에서 찾기
            selectedModelPath = FindModelFile();
            InitializeComponent();
            InitializeCustomComponents();
        }

        private string FindModelFile()
        {
            // 여러 위치에서 모델 파일 찾기
            List<string> searchPaths = new List<string>();
            
            // 1. 실행 파일과 같은 디렉토리의 model 폴더
            searchPaths.Add(Path.Combine(Application.StartupPath, "model", "best.pt"));
            
            // 2. 프로젝트 루트의 model 폴더 (bin\Debug\net6.0-windows에서 3단계 위로)
            DirectoryInfo currentDir = new DirectoryInfo(Application.StartupPath);
            for (int i = 0; i < 4 && currentDir.Parent != null; i++)
            {
                string projectRootModel = Path.Combine(currentDir.FullName, "model", "best.pt");
                searchPaths.Add(projectRootModel);
                currentDir = currentDir.Parent;
            }
            
            // 3. 현재 작업 디렉토리의 model 폴더
            searchPaths.Add(Path.Combine(Directory.GetCurrentDirectory(), "model", "best.pt"));
            
            // 각 경로 확인
            foreach (string path in searchPaths)
            {
                if (File.Exists(path))
                {
                    // Git LFS 포인터 파일인지 확인
                    try
                    {
                        string content = File.ReadAllText(path, System.Text.Encoding.UTF8);
                        if (content.Contains("oid sha256:") && content.Contains("version https://git-lfs.github.com"))
                        {
                            // 포인터 파일이면 건너뛰기
                            continue;
                        }
                    }
                    catch
                    {
                        // 바이너리 파일이면 실제 모델 파일로 간주
                    }
                    
                    return path;
                }
            }
            
            // 찾지 못하면 기본 경로 반환
            return Path.Combine(Application.StartupPath, "model", "best.pt");
        }

        private string FindPythonScript()
        {
            // 여러 위치에서 Python 스크립트 찾기
            List<string> searchPaths = new List<string>();
            
            // 1. 실행 파일과 같은 디렉토리
            searchPaths.Add(Path.Combine(Application.StartupPath, "inference.py"));
            
            // 2. 프로젝트 루트 (bin\Debug\net6.0-windows에서 3단계 위로)
            DirectoryInfo currentDir = new DirectoryInfo(Application.StartupPath);
            for (int i = 0; i < 4 && currentDir.Parent != null; i++)
            {
                string projectRootScript = Path.Combine(currentDir.FullName, "inference.py");
                searchPaths.Add(projectRootScript);
                currentDir = currentDir.Parent;
            }
            
            // 3. 현재 작업 디렉토리
            searchPaths.Add(Path.Combine(Directory.GetCurrentDirectory(), "inference.py"));
            
            // 각 경로 확인
            foreach (string path in searchPaths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }
            
            // 찾지 못하면 기본 경로 반환
            return Path.Combine(Application.StartupPath, "inference.py");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form 설정
            this.Text = "YOLOv8 차량 탐지 GUI";
            this.Size = new Size(1200, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(800, 750);
            
            // 아이콘 설정
            string iconPath = Path.Combine(Application.StartupPath, "icon.ico");
            if (!File.Exists(iconPath))
            {
                // 프로젝트 루트에서 찾기
                DirectoryInfo currentDir = new DirectoryInfo(Application.StartupPath);
                for (int i = 0; i < 4 && currentDir.Parent != null; i++)
                {
                    string projectRootIcon = Path.Combine(currentDir.FullName, "icon.ico");
                    if (File.Exists(projectRootIcon))
                    {
                        iconPath = projectRootIcon;
                        break;
                    }
                    currentDir = currentDir.Parent;
                }
            }
            
            if (File.Exists(iconPath))
            {
                try
                {
                    this.Icon = new Icon(iconPath);
                }
                catch
                {
                    // 아이콘 로드 실패 시 무시
                }
            }

            // 이미지 드롭 패널
            imageDropPanel = new Panel();
            imageDropPanel.Location = new Point(10, 10);
            imageDropPanel.Size = new Size(400, 300);
            imageDropPanel.BorderStyle = BorderStyle.FixedSingle;
            imageDropPanel.BackColor = Color.White;
            imageDropPanel.AllowDrop = true;
            imageDropPanel.DragEnter += ImageDropPanel_DragEnter;
            imageDropPanel.DragDrop += ImageDropPanel_DragDrop;
            imageDropPanel.Paint += ImageDropPanel_Paint;

            dropLabel = new Label();
            dropLabel.Text = "이미지 또는 비디오를 여기에 드래그하거나\n클릭하여 선택하세요";
            dropLabel.TextAlign = ContentAlignment.MiddleCenter;
            dropLabel.Location = new Point(10, 10);
            dropLabel.Size = new Size(380, 230);
            dropLabel.Font = new Font("맑은 고딕", 12F, FontStyle.Regular);
            dropLabel.ForeColor = Color.DarkGray;
            imageDropPanel.Controls.Add(dropLabel);

            // 진행률 표시 ProgressBar
            progressBar = new ProgressBar();
            progressBar.Location = new Point(10, 250);
            progressBar.Size = new Size(380, 25);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Visible = false;
            imageDropPanel.Controls.Add(progressBar);

            // 진행률 퍼센트 라벨
            progressLabel = new Label();
            progressLabel.Location = new Point(10, 250);
            progressLabel.Size = new Size(380, 25);
            progressLabel.TextAlign = ContentAlignment.MiddleCenter;
            progressLabel.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
            progressLabel.ForeColor = Color.Blue;
            progressLabel.BackColor = Color.Transparent;
            progressLabel.Visible = false;
            imageDropPanel.Controls.Add(progressLabel);

            // 이미지 선택 버튼
            selectImageButton = new Button();
            selectImageButton.Text = "파일 선택";
            selectImageButton.Location = new Point(10, 320);
            selectImageButton.Size = new Size(120, 35);
            selectImageButton.Click += SelectImageButton_Click;

            // 모델 경로 라벨 (숨김 처리)
            modelPathLabel = new Label();
            modelPathLabel.Visible = false;

            // 결과 리스트뷰
            resultListView = new ListView();
            resultListView.Location = new Point(420, 10);
            resultListView.Size = new Size(760, 650);
            resultListView.View = View.Details;
            resultListView.FullRowSelect = true;
            resultListView.GridLines = true;
            resultListView.DoubleClick += ResultListView_DoubleClick;
            resultListView.SelectedIndexChanged += ResultListView_SelectedIndexChanged;
            resultListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultListView.Columns.Add("번호", 60);
            resultListView.Columns.Add("파일명", 250);
            resultListView.Columns.Add("경로", 450);
            
            // 리스트뷰 라벨 추가
            Label resultLabel = new Label();
            resultLabel.Text = "탐지 결과 목록 (선택 시 미리보기, 더블 클릭으로 열기)";
            resultLabel.Location = new Point(420, 665);
            resultLabel.Size = new Size(760, 20);
            resultLabel.Font = new Font("맑은 고딕", 9F, FontStyle.Regular);
            resultLabel.ForeColor = Color.DarkGray;
            this.Controls.Add(resultLabel);
            
            // 사용방법 라벨 (왼쪽 하단)
            Label usageLabel = new Label();
            usageLabel.Text = "【 사용방법 】\n" +
                             "• 이미지/비디오를 왼쪽 패널에 드래그하거나\n" +
                             "  '이미지 선택' 버튼을 클릭하세요\n" +
                             "• 탐지가 완료되면 오른쪽 목록에 결과가 표시됩니다\n" +
                             "• 목록에서 항목을 선택하면 왼쪽에 미리보기가 표시됩니다\n" +
                             "• 이미지는 더블 클릭으로 외부 프로그램에서 열 수 있습니다";
            usageLabel.Location = new Point(10, 360);
            usageLabel.Size = new Size(400, 120);
            usageLabel.Font = new Font("맑은 고딕", 9F, FontStyle.Regular);
            usageLabel.ForeColor = Color.DarkBlue;
            this.Controls.Add(usageLabel);

            // 컨트롤 추가
            this.Controls.Add(imageDropPanel);
            this.Controls.Add(selectImageButton);
            this.Controls.Add(modelPathLabel);
            this.Controls.Add(resultListView);

            // 출력 폴더 생성
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            // 기존 결과 로드
            LoadExistingResults();

            this.ResumeLayout(false);
        }

        private void InitializeCustomComponents()
        {
            // 패널 클릭 이벤트
            imageDropPanel.Click += (s, e) => SelectImageButton_Click(s, e);
        }

        private void ImageDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ImageDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                ProcessMedia(files[0]);
            }
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "미디어 파일|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.mp4;*.avi;*.mov;*.mkv;*.wmv;*.flv;*.webm;*.m4v|이미지 파일|*.jpg;*.jpeg;*.png;*.bmp;*.gif|비디오 파일|*.mp4;*.avi;*.mov;*.mkv;*.wmv;*.flv;*.webm;*.m4v|모든 파일|*.*";
                dialog.Title = "이미지 또는 비디오 선택";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ProcessMedia(dialog.FileName);
                }
            }
        }


        private bool IsVideoFile(string filePath)
        {
            string[] videoExtensions = { ".mp4", ".avi", ".mov", ".mkv", ".wmv", ".flv", ".webm", ".m4v" };
            string extension = Path.GetExtension(filePath).ToLower();
            return videoExtensions.Contains(extension);
        }

        private async void ProcessMedia(string mediaPath)
        {
            // 모델 파일 확인
            if (!File.Exists(selectedModelPath))
            {
                MessageBox.Show($"모델 파일을 찾을 수 없습니다.\n경로: {selectedModelPath}\n\n해결 방법:\n1. setup_and_download.bat 실행\n2. 또는 model\\best.pt 파일을 확인하세요", 
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Git LFS 포인터 파일인지 확인
            bool isPointerFile = false;
            try
            {
                string content = File.ReadAllText(selectedModelPath, System.Text.Encoding.UTF8);
                if (content.Contains("oid sha256:") && content.Contains("version https://git-lfs.github.com"))
                {
                    isPointerFile = true;
                }
            }
            catch
            {
                // 바이너리 파일이면 실제 모델 파일
            }

            if (isPointerFile)
            {
                MessageBox.Show($"모델 파일이 Git LFS 포인터 파일입니다.\n실제 모델 파일을 다운로드해야 합니다.\n\n해결 방법:\n1. setup_and_download.bat 실행\n2. 또는 Git LFS를 사용하여 모델 다운로드", 
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Python 스크립트 찾기
            string pythonScript = FindPythonScript();
            if (!File.Exists(pythonScript))
            {
                MessageBox.Show($"Python 스크립트를 찾을 수 없습니다.\n경로: {pythonScript}\n\ninference.py 파일이 프로젝트 루트에 있는지 확인하세요.", 
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isVideo = IsVideoFile(mediaPath);
            
            try
            {
                // 진행 표시 초기화
                dropLabel.Text = isVideo ? "비디오 처리 중..." : "이미지 처리 중...";
                dropLabel.ForeColor = Color.Blue;
                dropLabel.Visible = true;
                progressBar.Value = 0;
                progressBar.Visible = true;
                progressLabel.Text = "0%";
                progressLabel.Visible = true;
                progressLabel.BringToFront();
                if (imageDropPanel.BackgroundImage != null)
                {
                    imageDropPanel.BackgroundImage.Dispose();
                    imageDropPanel.BackgroundImage = null;
                }
                this.Enabled = false;
                Application.DoEvents();

                // 출력 경로 설정
                string outputExtension = isVideo ? ".mp4" : ".jpg";
                string outputPath = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(mediaPath) + "_result" + outputExtension);

                // 경로를 정규화하여 백슬래시 문제 방지
                pythonScript = Path.GetFullPath(pythonScript);
                selectedModelPath = Path.GetFullPath(selectedModelPath);
                mediaPath = Path.GetFullPath(mediaPath);
                outputPath = Path.GetFullPath(outputPath);

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{pythonScript}\" \"{selectedModelPath}\" \"{mediaPath}\" \"{outputPath}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    WorkingDirectory = Path.GetDirectoryName(pythonScript)
                };

                using (Process process = Process.Start(psi))
                {
                    // 실시간 출력 읽기
                    var outputBuilder = new System.Text.StringBuilder();
                    var errorBuilder = new System.Text.StringBuilder();
                    
                    process.OutputDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            outputBuilder.AppendLine(e.Data);
                            
                            // 진행률 파싱
                            if (e.Data.StartsWith("PROGRESS:"))
                            {
                                string progressStr = e.Data.Substring("PROGRESS:".Length).Trim();
                                if (int.TryParse(progressStr, out int progress))
                                {
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        progressBar.Value = Math.Min(100, Math.Max(0, progress));
                                        progressLabel.Text = $"{progress}%";
                                        Application.DoEvents();
                                    });
                                }
                            }
                        }
                    };
                    
                    process.ErrorDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            errorBuilder.AppendLine(e.Data);
                        }
                    };
                    
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    
                    await process.WaitForExitAsync();
                    
                    string output = outputBuilder.ToString();
                    string error = errorBuilder.ToString();

                    if (process.ExitCode != 0)
                    {
                        throw new Exception($"Python 스크립트 실행 오류:\n{error}");
                    }
                }

                // 결과 파일이 생성되었는지 확인
                if (File.Exists(outputPath))
                {
                    // 리스트뷰에 추가
                    int itemNumber = resultListView.Items.Count + 1;
                    ListViewItem item = new ListViewItem(itemNumber.ToString());
                    item.SubItems.Add(Path.GetFileName(outputPath));
                    item.SubItems.Add(outputPath);
                    resultListView.Items.Add(item);

                    // 새로 추가된 항목 선택
                    item.Selected = true;
                    resultListView.EnsureVisible(resultListView.Items.Count - 1);

                    // 진행률 숨기기
                    progressBar.Visible = false;
                    progressLabel.Visible = false;
                    
                    // 결과 표시
                    if (isVideo)
                    {
                        // 비디오는 완료 메시지만 표시
                        dropLabel.Text = "비디오 처리 완료!";
                        dropLabel.ForeColor = Color.Green;
                        dropLabel.Visible = true;
                        imageDropPanel.BackgroundImage = null;
                    }
                    else
                    {
                        // 이미지는 바로 표시
                        DisplayImage(outputPath);
                    }

                    MessageBox.Show("탐지가 완료되었습니다!", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception($"결과 파일이 생성되지 않았습니다: {outputPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류가 발생했습니다:\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;
                progressBar.Visible = false;
                progressLabel.Visible = false;
                if (imageDropPanel.BackgroundImage == null)
                {
                    dropLabel.Text = "이미지 또는 비디오를 여기에 드래그하거나\n클릭하여 선택하세요";
                    dropLabel.ForeColor = Color.DarkGray;
                    dropLabel.Visible = true;
                }
            }
        }

        private void DisplayImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    // 기존 이미지 해제
                    if (imageDropPanel.BackgroundImage != null)
                    {
                        imageDropPanel.BackgroundImage.Dispose();
                        imageDropPanel.BackgroundImage = null;
                    }

                    Image img = Image.FromFile(imagePath);
                    float ratio = Math.Min((float)imageDropPanel.Width / img.Width, (float)imageDropPanel.Height / img.Height);
                    int newWidth = (int)(img.Width * ratio);
                    int newHeight = (int)(img.Height * ratio);

                    Bitmap resized = new Bitmap(img, newWidth, newHeight);
                    imageDropPanel.BackgroundImage = resized;
                    imageDropPanel.BackgroundImageLayout = ImageLayout.Center;
                    dropLabel.Visible = false;
                    
                    img.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지 표시 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultListView.SelectedItems.Count > 0)
            {
                string filePath = resultListView.SelectedItems[0].SubItems[2].Text;
                if (File.Exists(filePath))
                {
                    if (IsVideoFile(filePath))
                    {
                        // 비디오 파일인 경우 메시지 표시
                        dropLabel.Text = "비디오 파일 선택됨";
                        dropLabel.ForeColor = Color.Blue;
                        dropLabel.Visible = true;
                        if (imageDropPanel.BackgroundImage != null)
                        {
                            imageDropPanel.BackgroundImage.Dispose();
                            imageDropPanel.BackgroundImage = null;
                        }
                    }
                    else
                    {
                        // 이미지 파일인 경우 표시
                        DisplayImage(filePath);
                    }
                }
            }
        }

        private void ResultListView_DoubleClick(object sender, EventArgs e)
        {
            if (resultListView.SelectedItems.Count > 0)
            {
                string filePath = resultListView.SelectedItems[0].SubItems[2].Text;
                if (File.Exists(filePath))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"파일을 열 수 없습니다:\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ImageDropPanel_Paint(object sender, PaintEventArgs e)
        {
            if (imageDropPanel.BackgroundImage == null && dropLabel.Visible)
            {
                // 점선 테두리 그리기
                using (Pen pen = new Pen(Color.Gray, 2))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawRectangle(pen, 2, 2, imageDropPanel.Width - 4, imageDropPanel.Height - 4);
                }
            }
        }

        private void LoadExistingResults()
        {
            if (Directory.Exists(outputFolder))
            {
                // 이미지 파일
                string[] imageFiles = Directory.GetFiles(outputFolder, "*.jpg")
                    .Concat(Directory.GetFiles(outputFolder, "*.png"))
                    .Concat(Directory.GetFiles(outputFolder, "*.jpeg"))
                    .ToArray();
                
                // 비디오 파일
                string[] videoFiles = Directory.GetFiles(outputFolder, "*.mp4")
                    .Concat(Directory.GetFiles(outputFolder, "*.avi"))
                    .Concat(Directory.GetFiles(outputFolder, "*.mov"))
                    .Concat(Directory.GetFiles(outputFolder, "*.mkv"))
                    .Concat(Directory.GetFiles(outputFolder, "*.wmv"))
                    .Concat(Directory.GetFiles(outputFolder, "*.flv"))
                    .Concat(Directory.GetFiles(outputFolder, "*.webm"))
                    .Concat(Directory.GetFiles(outputFolder, "*.m4v"))
                    .ToArray();
                
                // 모든 파일 합치기
                string[] allFiles = imageFiles.Concat(videoFiles)
                    .OrderByDescending(f => File.GetCreationTime(f))
                    .ToArray();

                int itemNumber = 1;
                foreach (string file in allFiles)
                {
                    ListViewItem item = new ListViewItem(itemNumber.ToString());
                    item.SubItems.Add(Path.GetFileName(file));
                    item.SubItems.Add(file);
                    resultListView.Items.Add(item);
                    itemNumber++;
                }
            }
        }
    }
}

