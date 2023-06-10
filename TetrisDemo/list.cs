using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
namespace TetrisDemo
{
    public partial class list : Form
    {
        private const string RankingListFilePath = "RankingList.txt"; // 存储排行榜数据的文件路径

        private List<RankingItem> _rankings; // 排行榜数据列表

        public list()
        {
            InitializeComponent();
            LoadRankingList(); // 加载排行榜数据
        }

        // 加载排行榜数据
        private void LoadRankingList()
        {
            _rankings = new List<RankingItem>();
            if (File.Exists(RankingListFilePath))
            {
                // 从文本文件中读取排行榜数据
                var lines = File.ReadAllLines(RankingListFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(' ');
                    if (parts.Length >= 2 && int.TryParse(parts[1], out int score))
                    {
                        _rankings.Add(new RankingItem(parts[0], score));
                    }
                }
            }
            _rankings = _rankings.OrderByDescending(r => r.Score).ToList(); // 按积分从高到低排序
            UpdateUI(); // 更新UI显示
        }

        // 更新UI显示
        private void UpdateUI()
        {
            lvRanking.Items.Clear();
            foreach (var rankingItem in _rankings)
            {
                lvRanking.Items.Add(rankingItem.Name + "                        " + rankingItem.Score.ToString());

            }
        }

        // 添加排行榜项
        public void AddRanking(string name, int score)
        {
            _rankings.Add(new RankingItem(name, score));
            _rankings = _rankings.OrderByDescending(r => r.Score).ToList(); // 按积分从高到低排序
            UpdateUI(); // 更新UI显示

            // 将排行榜数据写入文本文件
            var lines = _rankings.Select(r => $"{r.Name}\t{r.Score}");
            File.WriteAllLines(RankingListFilePath, lines);
        }

        private void list_Load(object sender, EventArgs e)
        {

        }

        // 排行榜项类
        private class RankingItem
        {
            public string Name { get; }
            public int Score { get; }

            public RankingItem(string name, int score)
            {
                Name = name;
                Score = score;
            }
        }

        private void lvRanking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvRanking_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
