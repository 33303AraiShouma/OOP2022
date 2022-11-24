
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.地域 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPublishingOffice = new System.Windows.Forms.TextBox();
            this.tbWeather = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbTomorrow = new System.Windows.Forms.PictureBox();
            this.pbDayAfterTomorrow = new System.Windows.Forms.PictureBox();
            this.tbDayAfterTomorrow = new System.Windows.Forms.TextBox();
            this.tbTomorrow = new System.Windows.Forms.TextBox();
            this.pbDayAfter = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.最高 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.Label();
            this.tbTomorrowMax = new System.Windows.Forms.Label();
            this.tbTomorrowMin = new System.Windows.Forms.Label();
            this.tbDayAfterTomorrowMax = new System.Windows.Forms.Label();
            this.tbDayAfterTomorrowMin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(98, 346);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.ReadOnly = true;
            this.tbWeatherInfo.Size = new System.Drawing.Size(729, 174);
            this.tbWeatherInfo.TabIndex = 0;
            this.tbWeatherInfo.Text = " ";
            // 
            // cbRegion
            // 
            this.cbRegion.BackColor = System.Drawing.SystemColors.Window;
            this.cbRegion.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegion.ForeColor = System.Drawing.Color.Black;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "網走・北見・紋別地方",
            "十勝地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "三重県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "山口県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "奄美地方",
            "鹿児島県（奄美地方除く）",
            "沖縄本島地方",
            "大東島地方",
            "宮古島地方",
            "八重山地方"});
            this.cbRegion.Location = new System.Drawing.Point(336, 12);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(330, 32);
            this.cbRegion.TabIndex = 2;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // 地域
            // 
            this.地域.AutoSize = true;
            this.地域.BackColor = System.Drawing.Color.Transparent;
            this.地域.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.地域.ForeColor = System.Drawing.Color.DarkBlue;
            this.地域.Location = new System.Drawing.Point(260, 15);
            this.地域.Name = "地域";
            this.地域.Size = new System.Drawing.Size(66, 27);
            this.地域.TabIndex = 3;
            this.地域.Text = "地域";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "詳細";
            // 
            // tbPublishingOffice
            // 
            this.tbPublishingOffice.BackColor = System.Drawing.SystemColors.Window;
            this.tbPublishingOffice.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPublishingOffice.Location = new System.Drawing.Point(1153, 591);
            this.tbPublishingOffice.Multiline = true;
            this.tbPublishingOffice.Name = "tbPublishingOffice";
            this.tbPublishingOffice.ReadOnly = true;
            this.tbPublishingOffice.Size = new System.Drawing.Size(121, 53);
            this.tbPublishingOffice.TabIndex = 8;
            // 
            // tbWeather
            // 
            this.tbWeather.BackColor = System.Drawing.SystemColors.Window;
            this.tbWeather.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeather.Location = new System.Drawing.Point(3, 221);
            this.tbWeather.Multiline = true;
            this.tbWeather.Name = "tbWeather";
            this.tbWeather.ReadOnly = true;
            this.tbWeather.Size = new System.Drawing.Size(273, 76);
            this.tbWeather.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(152, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "今日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(430, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "明日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(689, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "明後日";
            // 
            // pbToday
            // 
            this.pbToday.BackColor = System.Drawing.Color.White;
            this.pbToday.Location = new System.Drawing.Point(3, 125);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(134, 83);
            this.pbToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbToday.TabIndex = 11;
            this.pbToday.TabStop = false;
            // 
            // pbTomorrow
            // 
            this.pbTomorrow.BackColor = System.Drawing.Color.White;
            this.pbTomorrow.Location = new System.Drawing.Point(306, 125);
            this.pbTomorrow.Name = "pbTomorrow";
            this.pbTomorrow.Size = new System.Drawing.Size(137, 83);
            this.pbTomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTomorrow.TabIndex = 12;
            this.pbTomorrow.TabStop = false;
            // 
            // pbDayAfterTomorrow
            // 
            this.pbDayAfterTomorrow.BackColor = System.Drawing.SystemColors.Window;
            this.pbDayAfterTomorrow.Location = new System.Drawing.Point(1599, 679);
            this.pbDayAfterTomorrow.Name = "pbDayAfterTomorrow";
            this.pbDayAfterTomorrow.Size = new System.Drawing.Size(134, 103);
            this.pbDayAfterTomorrow.TabIndex = 13;
            this.pbDayAfterTomorrow.TabStop = false;
            // 
            // tbDayAfterTomorrow
            // 
            this.tbDayAfterTomorrow.BackColor = System.Drawing.SystemColors.Window;
            this.tbDayAfterTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayAfterTomorrow.Location = new System.Drawing.Point(610, 221);
            this.tbDayAfterTomorrow.Multiline = true;
            this.tbDayAfterTomorrow.Name = "tbDayAfterTomorrow";
            this.tbDayAfterTomorrow.ReadOnly = true;
            this.tbDayAfterTomorrow.Size = new System.Drawing.Size(276, 76);
            this.tbDayAfterTomorrow.TabIndex = 9;
            // 
            // tbTomorrow
            // 
            this.tbTomorrow.BackColor = System.Drawing.SystemColors.Window;
            this.tbTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrow.Location = new System.Drawing.Point(306, 221);
            this.tbTomorrow.Multiline = true;
            this.tbTomorrow.Name = "tbTomorrow";
            this.tbTomorrow.ReadOnly = true;
            this.tbTomorrow.Size = new System.Drawing.Size(278, 76);
            this.tbTomorrow.TabIndex = 9;
            // 
            // pbDayAfter
            // 
            this.pbDayAfter.BackColor = System.Drawing.Color.White;
            this.pbDayAfter.Location = new System.Drawing.Point(610, 123);
            this.pbDayAfter.Name = "pbDayAfter";
            this.pbDayAfter.Size = new System.Drawing.Size(134, 83);
            this.pbDayAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDayAfter.TabIndex = 15;
            this.pbDayAfter.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(143, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "最低:";
            // 
            // 最高
            // 
            this.最高.AutoSize = true;
            this.最高.BackColor = System.Drawing.Color.Transparent;
            this.最高.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.最高.ForeColor = System.Drawing.Color.Red;
            this.最高.Location = new System.Drawing.Point(143, 127);
            this.最高.Name = "最高";
            this.最高.Size = new System.Drawing.Size(63, 24);
            this.最高.TabIndex = 16;
            this.最高.Text = "最高:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(449, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "最高:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(449, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "最低:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(750, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "最低:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(750, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "最高:";
            // 
            // tbMax
            // 
            this.tbMax.AutoSize = true;
            this.tbMax.BackColor = System.Drawing.Color.Transparent;
            this.tbMax.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbMax.Location = new System.Drawing.Point(212, 127);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(0, 24);
            this.tbMax.TabIndex = 17;
            // 
            // tbMin
            // 
            this.tbMin.AutoSize = true;
            this.tbMin.BackColor = System.Drawing.Color.Transparent;
            this.tbMin.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbMin.Location = new System.Drawing.Point(212, 179);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(0, 24);
            this.tbMin.TabIndex = 18;
            // 
            // tbTomorrowMax
            // 
            this.tbTomorrowMax.AutoSize = true;
            this.tbTomorrowMax.BackColor = System.Drawing.Color.Transparent;
            this.tbTomorrowMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrowMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTomorrowMax.Location = new System.Drawing.Point(518, 125);
            this.tbTomorrowMax.Name = "tbTomorrowMax";
            this.tbTomorrowMax.Size = new System.Drawing.Size(0, 24);
            this.tbTomorrowMax.TabIndex = 19;
            // 
            // tbTomorrowMin
            // 
            this.tbTomorrowMin.AutoSize = true;
            this.tbTomorrowMin.BackColor = System.Drawing.Color.Transparent;
            this.tbTomorrowMin.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrowMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTomorrowMin.Location = new System.Drawing.Point(518, 174);
            this.tbTomorrowMin.Name = "tbTomorrowMin";
            this.tbTomorrowMin.Size = new System.Drawing.Size(0, 24);
            this.tbTomorrowMin.TabIndex = 20;
            // 
            // tbDayAfterTomorrowMax
            // 
            this.tbDayAfterTomorrowMax.AutoSize = true;
            this.tbDayAfterTomorrowMax.BackColor = System.Drawing.Color.Transparent;
            this.tbDayAfterTomorrowMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayAfterTomorrowMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDayAfterTomorrowMax.Location = new System.Drawing.Point(823, 127);
            this.tbDayAfterTomorrowMax.Name = "tbDayAfterTomorrowMax";
            this.tbDayAfterTomorrowMax.Size = new System.Drawing.Size(0, 24);
            this.tbDayAfterTomorrowMax.TabIndex = 21;
            // 
            // tbDayAfterTomorrowMin
            // 
            this.tbDayAfterTomorrowMin.AutoSize = true;
            this.tbDayAfterTomorrowMin.BackColor = System.Drawing.Color.Transparent;
            this.tbDayAfterTomorrowMin.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayAfterTomorrowMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDayAfterTomorrowMin.Location = new System.Drawing.Point(823, 179);
            this.tbDayAfterTomorrowMin.Name = "tbDayAfterTomorrowMin";
            this.tbDayAfterTomorrowMin.Size = new System.Drawing.Size(0, 24);
            this.tbDayAfterTomorrowMin.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(241, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "℃";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(241, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "℃";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(559, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "℃";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(871, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "℃";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(559, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "℃";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(871, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "℃";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.ssssssssss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 566);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDayAfterTomorrowMin);
            this.Controls.Add(this.tbDayAfterTomorrowMax);
            this.Controls.Add(this.tbTomorrowMin);
            this.Controls.Add(this.tbTomorrowMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.最高);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDayAfter);
            this.Controls.Add(this.pbDayAfterTomorrow);
            this.Controls.Add(this.pbTomorrow);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTomorrow);
            this.Controls.Add(this.tbDayAfterTomorrow);
            this.Controls.Add(this.tbWeather);
            this.Controls.Add(this.tbPublishingOffice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.地域);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.tbWeatherInfo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "天気予報アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label 地域;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPublishingOffice;
        private System.Windows.Forms.TextBox tbWeather;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTomorrow;
        private System.Windows.Forms.PictureBox pbDayAfterTomorrow;
        private System.Windows.Forms.TextBox tbDayAfterTomorrow;
        private System.Windows.Forms.TextBox tbTomorrow;
        private System.Windows.Forms.PictureBox pbDayAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 最高;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tbMax;
        private System.Windows.Forms.Label tbMin;
        private System.Windows.Forms.Label tbTomorrowMax;
        private System.Windows.Forms.Label tbTomorrowMin;
        private System.Windows.Forms.Label tbDayAfterTomorrowMax;
        private System.Windows.Forms.Label tbDayAfterTomorrowMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

