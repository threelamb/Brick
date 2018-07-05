namespace TestThreadPool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.lb_sleepMilliseconds = new System.Windows.Forms.Label();
            this.tb_threadCount = new System.Windows.Forms.TextBox();
            this.lb_ThreadCount = new System.Windows.Forms.Label();
            this.lb_minCompletionPortThreads = new System.Windows.Forms.Label();
            this.tb_minWorkerThreads = new System.Windows.Forms.TextBox();
            this.lb_minWorkerThreads = new System.Windows.Forms.Label();
            this.lb_maxCompletionPortThreads = new System.Windows.Forms.Label();
            this.lb_maxWorkerThreads = new System.Windows.Forms.Label();
            this.tb_maxWorkerThreads = new System.Windows.Forms.TextBox();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.bt_Start = new System.Windows.Forms.Button();
            this.tb_maxCompletionPortThreads = new System.Windows.Forms.TextBox();
            this.tb_minCompletionPortThreads = new System.Windows.Forms.TextBox();
            this.tb_sleepMilliseconds = new System.Windows.Forms.TextBox();
            this.lb_CompleteThreadCount = new System.Windows.Forms.Label();
            this.lb_RunningThreadCount = new System.Windows.Forms.Label();
            this.bt_AppendThreadCount = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bt_AppendThreadCount, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_Stop, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_sleepMilliseconds, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_threadCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_ThreadCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_minCompletionPortThreads, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_minWorkerThreads, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_minWorkerThreads, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_maxCompletionPortThreads, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_maxWorkerThreads, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_maxWorkerThreads, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_result, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bt_Start, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_maxCompletionPortThreads, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_minCompletionPortThreads, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_sleepMilliseconds, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_CompleteThreadCount, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_RunningThreadCount, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 502);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bt_Stop
            // 
            this.bt_Stop.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Stop.Location = new System.Drawing.Point(114, 63);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(75, 43);
            this.bt_Stop.TabIndex = 14;
            this.bt_Stop.Text = "结束";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // lb_sleepMilliseconds
            // 
            this.lb_sleepMilliseconds.AutoSize = true;
            this.lb_sleepMilliseconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sleepMilliseconds.Location = new System.Drawing.Point(336, 40);
            this.lb_sleepMilliseconds.Name = "lb_sleepMilliseconds";
            this.lb_sleepMilliseconds.Size = new System.Drawing.Size(105, 20);
            this.lb_sleepMilliseconds.TabIndex = 10;
            this.lb_sleepMilliseconds.Text = "sleepMilliseconds";
            this.lb_sleepMilliseconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_threadCount
            // 
            this.tb_threadCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_threadCount.Location = new System.Drawing.Point(114, 43);
            this.tb_threadCount.Name = "tb_threadCount";
            this.tb_threadCount.Size = new System.Drawing.Size(105, 21);
            this.tb_threadCount.TabIndex = 9;
            this.tb_threadCount.Text = "500";
            // 
            // lb_ThreadCount
            // 
            this.lb_ThreadCount.AutoSize = true;
            this.lb_ThreadCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_ThreadCount.Location = new System.Drawing.Point(37, 40);
            this.lb_ThreadCount.Name = "lb_ThreadCount";
            this.lb_ThreadCount.Size = new System.Drawing.Size(71, 20);
            this.lb_ThreadCount.TabIndex = 8;
            this.lb_ThreadCount.Text = "threadCount";
            this.lb_ThreadCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_minCompletionPortThreads
            // 
            this.lb_minCompletionPortThreads.AutoSize = true;
            this.lb_minCompletionPortThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_minCompletionPortThreads.Location = new System.Drawing.Point(336, 20);
            this.lb_minCompletionPortThreads.Name = "lb_minCompletionPortThreads";
            this.lb_minCompletionPortThreads.Size = new System.Drawing.Size(105, 20);
            this.lb_minCompletionPortThreads.TabIndex = 6;
            this.lb_minCompletionPortThreads.Text = "minCompletionPortThreads";
            this.lb_minCompletionPortThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_minWorkerThreads
            // 
            this.tb_minWorkerThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_minWorkerThreads.Location = new System.Drawing.Point(114, 23);
            this.tb_minWorkerThreads.Name = "tb_minWorkerThreads";
            this.tb_minWorkerThreads.Size = new System.Drawing.Size(105, 21);
            this.tb_minWorkerThreads.TabIndex = 5;
            this.tb_minWorkerThreads.Text = "1000";
            // 
            // lb_minWorkerThreads
            // 
            this.lb_minWorkerThreads.AutoSize = true;
            this.lb_minWorkerThreads.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_minWorkerThreads.Location = new System.Drawing.Point(7, 20);
            this.lb_minWorkerThreads.Name = "lb_minWorkerThreads";
            this.lb_minWorkerThreads.Size = new System.Drawing.Size(101, 20);
            this.lb_minWorkerThreads.TabIndex = 4;
            this.lb_minWorkerThreads.Text = "minWorkerThreads";
            this.lb_minWorkerThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_maxCompletionPortThreads
            // 
            this.lb_maxCompletionPortThreads.AutoSize = true;
            this.lb_maxCompletionPortThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_maxCompletionPortThreads.Location = new System.Drawing.Point(336, 0);
            this.lb_maxCompletionPortThreads.Name = "lb_maxCompletionPortThreads";
            this.lb_maxCompletionPortThreads.Size = new System.Drawing.Size(105, 20);
            this.lb_maxCompletionPortThreads.TabIndex = 2;
            this.lb_maxCompletionPortThreads.Text = "maxCompletionPortThreads";
            this.lb_maxCompletionPortThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_maxWorkerThreads
            // 
            this.lb_maxWorkerThreads.AutoSize = true;
            this.lb_maxWorkerThreads.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_maxWorkerThreads.Location = new System.Drawing.Point(7, 0);
            this.lb_maxWorkerThreads.Name = "lb_maxWorkerThreads";
            this.lb_maxWorkerThreads.Size = new System.Drawing.Size(101, 20);
            this.lb_maxWorkerThreads.TabIndex = 0;
            this.lb_maxWorkerThreads.Text = "maxWorkerThreads";
            this.lb_maxWorkerThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_maxWorkerThreads
            // 
            this.tb_maxWorkerThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_maxWorkerThreads.Location = new System.Drawing.Point(114, 3);
            this.tb_maxWorkerThreads.Name = "tb_maxWorkerThreads";
            this.tb_maxWorkerThreads.Size = new System.Drawing.Size(105, 21);
            this.tb_maxWorkerThreads.TabIndex = 1;
            this.tb_maxWorkerThreads.Text = "2000";
            // 
            // rtb_result
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtb_result, 5);
            this.rtb_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_result.Location = new System.Drawing.Point(3, 112);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtb_result.Size = new System.Drawing.Size(553, 387);
            this.rtb_result.TabIndex = 12;
            this.rtb_result.Text = "";
            // 
            // bt_Start
            // 
            this.bt_Start.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Start.Location = new System.Drawing.Point(3, 63);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 43);
            this.bt_Start.TabIndex = 13;
            this.bt_Start.Text = "开始";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // tb_maxCompletionPortThreads
            // 
            this.tb_maxCompletionPortThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_maxCompletionPortThreads.Location = new System.Drawing.Point(447, 3);
            this.tb_maxCompletionPortThreads.Name = "tb_maxCompletionPortThreads";
            this.tb_maxCompletionPortThreads.Size = new System.Drawing.Size(109, 21);
            this.tb_maxCompletionPortThreads.TabIndex = 3;
            this.tb_maxCompletionPortThreads.Text = "2000";
            // 
            // tb_minCompletionPortThreads
            // 
            this.tb_minCompletionPortThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_minCompletionPortThreads.Location = new System.Drawing.Point(447, 23);
            this.tb_minCompletionPortThreads.Name = "tb_minCompletionPortThreads";
            this.tb_minCompletionPortThreads.Size = new System.Drawing.Size(109, 21);
            this.tb_minCompletionPortThreads.TabIndex = 7;
            this.tb_minCompletionPortThreads.Text = "1000";
            // 
            // tb_sleepMilliseconds
            // 
            this.tb_sleepMilliseconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sleepMilliseconds.Location = new System.Drawing.Point(447, 43);
            this.tb_sleepMilliseconds.Name = "tb_sleepMilliseconds";
            this.tb_sleepMilliseconds.Size = new System.Drawing.Size(109, 21);
            this.tb_sleepMilliseconds.TabIndex = 11;
            this.tb_sleepMilliseconds.Text = "100";
            // 
            // lb_CompleteThreadCount
            // 
            this.lb_CompleteThreadCount.AutoSize = true;
            this.lb_CompleteThreadCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CompleteThreadCount.Location = new System.Drawing.Point(447, 60);
            this.lb_CompleteThreadCount.Name = "lb_CompleteThreadCount";
            this.lb_CompleteThreadCount.Size = new System.Drawing.Size(109, 49);
            this.lb_CompleteThreadCount.TabIndex = 16;
            this.lb_CompleteThreadCount.Text = "0";
            this.lb_CompleteThreadCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_RunningThreadCount
            // 
            this.lb_RunningThreadCount.AutoSize = true;
            this.lb_RunningThreadCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_RunningThreadCount.Location = new System.Drawing.Point(336, 60);
            this.lb_RunningThreadCount.Name = "lb_RunningThreadCount";
            this.lb_RunningThreadCount.Size = new System.Drawing.Size(105, 49);
            this.lb_RunningThreadCount.TabIndex = 15;
            this.lb_RunningThreadCount.Text = "0";
            this.lb_RunningThreadCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_AppendThreadCount
            // 
            this.bt_AppendThreadCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_AppendThreadCount.Location = new System.Drawing.Point(225, 63);
            this.bt_AppendThreadCount.Name = "bt_AppendThreadCount";
            this.bt_AppendThreadCount.Size = new System.Drawing.Size(75, 43);
            this.bt_AppendThreadCount.TabIndex = 17;
            this.bt_AppendThreadCount.Text = "追加线程";
            this.bt_AppendThreadCount.UseVisualStyleBackColor = true;
            this.bt_AppendThreadCount.Click += new System.EventHandler(this.bt_AppendThreadCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_maxCompletionPortThreads;
        private System.Windows.Forms.Label lb_maxCompletionPortThreads;
        private System.Windows.Forms.Label lb_maxWorkerThreads;
        private System.Windows.Forms.TextBox tb_maxWorkerThreads;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.TextBox tb_sleepMilliseconds;
        private System.Windows.Forms.Label lb_sleepMilliseconds;
        private System.Windows.Forms.TextBox tb_threadCount;
        private System.Windows.Forms.Label lb_ThreadCount;
        private System.Windows.Forms.TextBox tb_minCompletionPortThreads;
        private System.Windows.Forms.Label lb_minCompletionPortThreads;
        private System.Windows.Forms.TextBox tb_minWorkerThreads;
        private System.Windows.Forms.Label lb_minWorkerThreads;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Label lb_RunningThreadCount;
        private System.Windows.Forms.Label lb_CompleteThreadCount;
        private System.Windows.Forms.Button bt_AppendThreadCount;
    }
}

