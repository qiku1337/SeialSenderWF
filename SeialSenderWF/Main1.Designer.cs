
namespace SeialSenderWF
{
    partial class Main1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.port_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speed_combo = new System.Windows.Forms.ComboBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.log_textbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.write_button = new System.Windows.Forms.Button();
            this.check_button = new System.Windows.Forms.Button();
            this.ok_label = new System.Windows.Forms.Label();
            this.pn_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // port_combo
            // 
            this.port_combo.FormattingEnabled = true;
            this.port_combo.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.port_combo.Location = new System.Drawing.Point(451, 38);
            this.port_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.port_combo.Name = "port_combo";
            this.port_combo.Size = new System.Drawing.Size(91, 24);
            this.port_combo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speed:";
            // 
            // speed_combo
            // 
            this.speed_combo.FormattingEnabled = true;
            this.speed_combo.Items.AddRange(new object[] {
            " 9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "256000"});
            this.speed_combo.Location = new System.Drawing.Point(451, 71);
            this.speed_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speed_combo.Name = "speed_combo";
            this.speed_combo.Size = new System.Drawing.Size(91, 24);
            this.speed_combo.TabIndex = 3;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(396, 143);
            this.connect_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(147, 31);
            this.connect_button.TabIndex = 4;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // log_textbox
            // 
            this.log_textbox.HideSelection = false;
            this.log_textbox.Location = new System.Drawing.Point(16, 38);
            this.log_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.log_textbox.Size = new System.Drawing.Size(356, 207);
            this.log_textbox.TabIndex = 5;
            this.log_textbox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(164, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log:";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(420, 251);
            this.send_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(92, 44);
            this.send_button.TabIndex = 7;
            this.send_button.Text = "Boot";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(397, 105);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(145, 31);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Save settings";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(396, 181);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(145, 31);
            this.button_disconnect.TabIndex = 9;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // write_button
            // 
            this.write_button.Location = new System.Drawing.Point(420, 303);
            this.write_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(92, 44);
            this.write_button.TabIndex = 10;
            this.write_button.Text = "Write PN";
            this.write_button.UseVisualStyleBackColor = true;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(420, 354);
            this.check_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(92, 50);
            this.check_button.TabIndex = 11;
            this.check_button.Text = "Check PN";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // ok_label
            // 
            this.ok_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok_label.AutoSize = true;
            this.ok_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_label.Location = new System.Drawing.Point(76, 303);
            this.ok_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ok_label.Name = "ok_label";
            this.ok_label.Size = new System.Drawing.Size(89, 63);
            this.ok_label.TabIndex = 12;
            this.ok_label.Text = "??";
            // 
            // pn_box
            // 
            this.pn_box.Location = new System.Drawing.Point(395, 219);
            this.pn_box.Name = "pn_box";
            this.pn_box.Size = new System.Drawing.Size(144, 22);
            this.pn_box.TabIndex = 13;
            // 
            // Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 438);
            this.Controls.Add(this.pn_box);
            this.Controls.Add(this.ok_label);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.write_button);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.speed_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_combo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main1";
            this.Text = "QSerialSender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox port_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox speed_combo;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.RichTextBox log_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Label ok_label;
        private System.Windows.Forms.TextBox pn_box;
    }
}

