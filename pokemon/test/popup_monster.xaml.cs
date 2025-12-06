using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace test
{
    public class Pokemon
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Evolution { get; set; }

        public string ImagePath { get; set; } // 필요시 추가
    }

    /// <summary>
    /// popup_monster.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class popup_monster : Window
    {
        private List<Pokemon> pokemons;

        public popup_monster()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>
            {
                new Pokemon
                {
                    Number = "No. 0001",
                    Name = "이상해씨",
                    Type = "풀 / 독 타입",
                    Category = "씨앗 포켓몬",
                    Height = "0.7m",
                    Weight = "6.9kg",
                    Evolution = "이상해씨",
                    ImagePath = "C:\\Users\\Yerim\\OneDrive\\바탕 화면\\test\\test\\image\\Bulbasaur.jpg"
                },
                new Pokemon
                {
                    Number = "No. 0004",
                    Name = "파이리",
                    Type = "불꽃 타입",
                    Category = "도롱뇽 포켓몬",
                    Height = "0.6m",
                    Weight = "8.5kg",
                    Evolution = "리자드",
                    ImagePath="C:\\Users\\Yerim\\OneDrive\\바탕 화면\\test\\test\\image\\fire.jpg"
                },
                new Pokemon
                {
                    Number = "No. 0007",
                    Name = "꼬북이",
                    Type = "물 타입",
                    Category = "거북 포켓몬",
                    Height = "0.5m",
                    Weight = "9.0kg",
                    Evolution = "어니부기",
                    ImagePath="C:\\Users\\Yerim\\OneDrive\\바탕 화면\\test\\test\\image\\Kobuk.jpg"
                },
                new Pokemon
                {
                    Number = "No. 0054",
                    Name = "고라파덕",
                    Type = "물 타입",
                    Category = "오리 포켓몬",
                    Height = "0.8m",
                    Weight = "19.6kg",
                    Evolution = "골덕",
                    ImagePath="C:\\Users\\Yerim\\OneDrive\\바탕 화면\\test\\test\\image\\gora.jpg"
                },
                new Pokemon
                {
                    Number = "No. 0039",
                    Name = "푸린",
                    Type = "노말 / 페어리 타입",
                    Category = "풍선 포켓몬",
                    Height = "0.5m",
                    Weight = "5.5kg",
                    Evolution = "푸크린",
                    ImagePath="C:\\Users\\Yerim\\OneDrive\\바탕 화면\\test\\test\\image\\purine.jpg"
                },
                new Pokemon
                {
                    Number = "No. 0025",
                    Name = "피카츄",
                    Type = "전기 타입",
                    Category = "쥐 포켓몬",
                    Height = "0.4m",
                    Weight = "6.0kg",
                    Evolution = "라이츄",
                    ImagePath="C:\\Users\\Yerim\\OneDrive\\바탕 화면\\test\\test\\image\\pikachu.jpg"
                }
            };
        }

        private void ResetBorders()
        {
            Border[] allBorders = { border00, border01, border02, border03, border04, border05 };

            foreach (var border in allBorders)
            {
                border.Background = Brushes.LightGray;
                border.BorderBrush = Brushes.Transparent;
                border.BorderThickness = new Thickness(0);
            }
        }

        private void select00(object sender, MouseButtonEventArgs e)
        {
            ResetBorders();
            border00.Background = Brushes.White;
            border00.BorderBrush = Brushes.Red;
            border00.BorderThickness = new Thickness(3);
            SetPokemonInfo(0);
        }
        private void select01(object sender, MouseButtonEventArgs e)
        {
            ResetBorders();
            border01.Background = Brushes.White;
            border01.BorderBrush = Brushes.Red;
            border01.BorderThickness = new Thickness(3);
            SetPokemonInfo(1);
        }
        private void select02(object sender, MouseButtonEventArgs e)
        {
            ResetBorders();
            border02.Background = Brushes.White;
            border02.BorderBrush = Brushes.Red;
            border02.BorderThickness = new Thickness(3);
            SetPokemonInfo(2);
        }
        private void select03(object sender, MouseButtonEventArgs e)
        {
            ResetBorders();
            border03.Background = Brushes.White;
            border03.BorderBrush = Brushes.Red;
            border03.BorderThickness = new Thickness(3);
            SetPokemonInfo(3);
        }
        private void select04(object sender, MouseButtonEventArgs e)
        {
            ResetBorders();
            border04.Background = Brushes.White;
            border04.BorderBrush = Brushes.Red;
            border04.BorderThickness = new Thickness(3);
            SetPokemonInfo(4);
        }
        private void select05(object sender, MouseButtonEventArgs e)
        {
            ResetBorders();
            border05.Background = Brushes.White;
            border05.BorderBrush = Brushes.Red;
            border05.BorderThickness = new Thickness(3);
            SetPokemonInfo(5);
        }
        private void select06(object sender, MouseButtonEventArgs e)
        {
            SetPokemonInfo(6);
        }

        private void SetPokemonInfo(int index)
        {
            var selectedPokemon = pokemons[index];
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.txtNumber.Text = selectedPokemon.Number;
            mainwindow.txtName.Text = selectedPokemon.Name;
            mainwindow.txttype.Text = selectedPokemon.Type;
            mainwindow.txtCategory.Text = selectedPokemon.Category;
            mainwindow.txtHeight.Text = selectedPokemon.Height;
            mainwindow.txtWeight.Text = selectedPokemon.Weight;
            mainwindow.txtEvolution.Text = selectedPokemon.Evolution;

            // 이미지 초기화 및 할당
            if (!string.IsNullOrEmpty(selectedPokemon.ImagePath))
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedPokemon.ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                mainwindow.pokemonImage.Source = bitmap;
            }
            else
            {
                mainwindow.pokemonImage.Source = null;
            }

            Close();
        }
    }
}
