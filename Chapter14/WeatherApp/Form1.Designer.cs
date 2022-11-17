
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPublishingOffice = new System.Windows.Forms.TextBox();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.tbWeather = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbTomorrow = new System.Windows.Forms.PictureBox();
            this.pbDayAfterTomorrow = new System.Windows.Forms.PictureBox();
            this.tbDayAfterTomorrow = new System.Windows.Forms.TextBox();
            this.tbTomorrow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(163, 221);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.ReadOnly = true;
            this.tbWeatherInfo.Size = new System.Drawing.Size(373, 266);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // cbRegion
            // 
            this.cbRegion.BackColor = System.Drawing.SystemColors.Window;
            this.cbRegion.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
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
            this.cbRegion.Location = new System.Drawing.Point(163, 168);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(373, 35);
            this.cbRegion.TabIndex = 2;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // 地域
            // 
            this.地域.AutoSize = true;
            this.地域.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.地域.Location = new System.Drawing.Point(12, 176);
            this.地域.Name = "地域";
            this.地域.Size = new System.Drawing.Size(68, 27);
            this.地域.TabIndex = 3;
            this.地域.Text = "地域";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "詳細";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "報告日時";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "発表者";
            // 
            // tbPublishingOffice
            // 
            this.tbPublishingOffice.BackColor = System.Drawing.SystemColors.Window;
            this.tbPublishingOffice.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPublishingOffice.Location = new System.Drawing.Point(163, 52);
            this.tbPublishingOffice.Multiline = true;
            this.tbPublishingOffice.Name = "tbPublishingOffice";
            this.tbPublishingOffice.ReadOnly = true;
            this.tbPublishingOffice.Size = new System.Drawing.Size(272, 53);
            this.tbPublishingOffice.TabIndex = 8;
            // 
            // tbDateTime
            // 
            this.tbDateTime.BackColor = System.Drawing.SystemColors.Window;
            this.tbDateTime.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDateTime.Location = new System.Drawing.Point(163, 111);
            this.tbDateTime.Multiline = true;
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.ReadOnly = true;
            this.tbDateTime.Size = new System.Drawing.Size(272, 51);
            this.tbDateTime.TabIndex = 8;
            // 
            // tbWeather
            // 
            this.tbWeather.BackColor = System.Drawing.SystemColors.Window;
            this.tbWeather.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeather.Location = new System.Drawing.Point(614, 110);
            this.tbWeather.Name = "tbWeather";
            this.tbWeather.ReadOnly = true;
            this.tbWeather.Size = new System.Drawing.Size(352, 28);
            this.tbWeather.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(542, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "今日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(542, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "明日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(542, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "明後日";
            // 
            // pbToday
            // 
            this.pbToday.BackColor = System.Drawing.SystemColors.Window;
            this.pbToday.Location = new System.Drawing.Point(704, 12);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(134, 92);
            this.pbToday.TabIndex = 11;
            this.pbToday.TabStop = false;
            // 
            // pbTomorrow
            // 
            this.pbTomorrow.BackColor = System.Drawing.SystemColors.Window;
            this.pbTomorrow.Location = new System.Drawing.Point(704, 156);
            this.pbTomorrow.Name = "pbTomorrow";
            this.pbTomorrow.Size = new System.Drawing.Size(134, 99);
            this.pbTomorrow.TabIndex = 12;
            this.pbTomorrow.TabStop = false;
            // 
            // pbDayAfterTomorrow
            // 
            this.pbDayAfterTomorrow.BackColor = System.Drawing.SystemColors.Window;
            this.pbDayAfterTomorrow.Location = new System.Drawing.Point(704, 302);
            this.pbDayAfterTomorrow.Name = "pbDayAfterTomorrow";
            this.pbDayAfterTomorrow.Size = new System.Drawing.Size(134, 103);
            this.pbDayAfterTomorrow.TabIndex = 13;
            this.pbDayAfterTomorrow.TabStop = false;
            // 
            // tbDayAfterTomorrow
            // 
            this.tbDayAfterTomorrow.BackColor = System.Drawing.SystemColors.Window;
            this.tbDayAfterTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayAfterTomorrow.Location = new System.Drawing.Point(614, 411);
            this.tbDayAfterTomorrow.Name = "tbDayAfterTomorrow";
            this.tbDayAfterTomorrow.ReadOnly = true;
            this.tbDayAfterTomorrow.Size = new System.Drawing.Size(352, 28);
            this.tbDayAfterTomorrow.TabIndex = 9;
            // 
            // tbTomorrow
            // 
            this.tbTomorrow.BackColor = System.Drawing.SystemColors.Window;
            this.tbTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrow.Location = new System.Drawing.Point(614, 258);
            this.tbTomorrow.Name = "tbTomorrow";
            this.tbTomorrow.ReadOnly = true;
            this.tbTomorrow.Size = new System.Drawing.Size(352, 28);
            this.tbTomorrow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 519);
            this.Controls.Add(this.pbDayAfterTomorrow);
            this.Controls.Add(this.pbTomorrow);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTomorrow);
            this.Controls.Add(this.tbDayAfterTomorrow);
            this.Controls.Add(this.tbWeather);
            this.Controls.Add(this.tbDateTime);
            this.Controls.Add(this.tbPublishingOffice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.地域);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTomorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label 地域;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPublishingOffice;
        private System.Windows.Forms.TextBox tbDateTime;
        private System.Windows.Forms.TextBox tbWeather;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTomorrow;
        private System.Windows.Forms.PictureBox pbDayAfterTomorrow;
        private System.Windows.Forms.TextBox tbDayAfterTomorrow;
        private System.Windows.Forms.TextBox tbTomorrow;
    }
}

