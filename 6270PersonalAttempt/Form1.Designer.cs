namespace _6270PersonalAttempt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.finishStandard = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deliveryTypeStandard = new System.Windows.Forms.ComboBox();
            this.PromoLabel = new System.Windows.Forms.Label();
            this.promoCodeTxt = new System.Windows.Forms.TextBox();
            this.placeOrderStandard = new System.Windows.Forms.Button();
            this.photoTypeStandard = new System.Windows.Forms.ComboBox();
            this.qtyStandard = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearOrder = new System.Windows.Forms.Button();
            this.placeOrderByPiece = new System.Windows.Forms.Button();
            this.addLineButton = new System.Windows.Forms.Button();
            this.deliveryTypeByPrint = new System.Windows.Forms.ComboBox();
            this.qtyByPrint = new System.Windows.Forms.NumericUpDown();
            this.photoSizeByPrint = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyStandard)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyByPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(40, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.finishStandard);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.deliveryTypeStandard);
            this.tabPage1.Controls.Add(this.PromoLabel);
            this.tabPage1.Controls.Add(this.promoCodeTxt);
            this.tabPage1.Controls.Add(this.placeOrderStandard);
            this.tabPage1.Controls.Add(this.photoTypeStandard);
            this.tabPage1.Controls.Add(this.qtyStandard);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "One Print Discount";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // finishStandard
            // 
            this.finishStandard.FormattingEnabled = true;
            this.finishStandard.Items.AddRange(new object[] {
            "Glossy",
            "Matte"});
            this.finishStandard.Location = new System.Drawing.Point(281, 40);
            this.finishStandard.Name = "finishStandard";
            this.finishStandard.Size = new System.Drawing.Size(121, 33);
            this.finishStandard.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // deliveryTypeStandard
            // 
            this.deliveryTypeStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTypeStandard.FormattingEnabled = true;
            this.deliveryTypeStandard.Items.AddRange(new object[] {
            "One Hour",
            "Next Day"});
            this.deliveryTypeStandard.Location = new System.Drawing.Point(16, 141);
            this.deliveryTypeStandard.Name = "deliveryTypeStandard";
            this.deliveryTypeStandard.Size = new System.Drawing.Size(121, 33);
            this.deliveryTypeStandard.TabIndex = 2;
            // 
            // PromoLabel
            // 
            this.PromoLabel.AutoSize = true;
            this.PromoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoLabel.Location = new System.Drawing.Point(305, 104);
            this.PromoLabel.Name = "PromoLabel";
            this.PromoLabel.Size = new System.Drawing.Size(97, 20);
            this.PromoLabel.TabIndex = 5;
            this.PromoLabel.Text = "Promo Code";
            // 
            // promoCodeTxt
            // 
            this.promoCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promoCodeTxt.Location = new System.Drawing.Point(302, 143);
            this.promoCodeTxt.Name = "promoCodeTxt";
            this.promoCodeTxt.Size = new System.Drawing.Size(100, 31);
            this.promoCodeTxt.TabIndex = 4;
            // 
            // placeOrderStandard
            // 
            this.placeOrderStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderStandard.Location = new System.Drawing.Point(161, 104);
            this.placeOrderStandard.Name = "placeOrderStandard";
            this.placeOrderStandard.Size = new System.Drawing.Size(100, 70);
            this.placeOrderStandard.TabIndex = 3;
            this.placeOrderStandard.Text = "Place Order";
            this.placeOrderStandard.UseVisualStyleBackColor = true;
            this.placeOrderStandard.Click += new System.EventHandler(this.placeOrderStandard_Click);
            // 
            // photoTypeStandard
            // 
            this.photoTypeStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoTypeStandard.FormattingEnabled = true;
            this.photoTypeStandard.Items.AddRange(new object[] {
            "4x6",
            "5x7",
            "8x10"});
            this.photoTypeStandard.Location = new System.Drawing.Point(16, 42);
            this.photoTypeStandard.Name = "photoTypeStandard";
            this.photoTypeStandard.Size = new System.Drawing.Size(121, 33);
            this.photoTypeStandard.TabIndex = 1;
            // 
            // qtyStandard
            // 
            this.qtyStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyStandard.Location = new System.Drawing.Point(170, 42);
            this.qtyStandard.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyStandard.Name = "qtyStandard";
            this.qtyStandard.Size = new System.Drawing.Size(78, 31);
            this.qtyStandard.TabIndex = 0;
            this.qtyStandard.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearOrder);
            this.tabPage2.Controls.Add(this.placeOrderByPiece);
            this.tabPage2.Controls.Add(this.addLineButton);
            this.tabPage2.Controls.Add(this.deliveryTypeByPrint);
            this.tabPage2.Controls.Add(this.qtyByPrint);
            this.tabPage2.Controls.Add(this.photoSizeByPrint);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order By Print";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearOrder
            // 
            this.clearOrder.Location = new System.Drawing.Point(315, 120);
            this.clearOrder.Name = "clearOrder";
            this.clearOrder.Size = new System.Drawing.Size(93, 64);
            this.clearOrder.TabIndex = 5;
            this.clearOrder.Text = "Clear Order";
            this.clearOrder.UseVisualStyleBackColor = true;
            // 
            // placeOrderByPiece
            // 
            this.placeOrderByPiece.Location = new System.Drawing.Point(170, 120);
            this.placeOrderByPiece.Name = "placeOrderByPiece";
            this.placeOrderByPiece.Size = new System.Drawing.Size(93, 64);
            this.placeOrderByPiece.TabIndex = 4;
            this.placeOrderByPiece.Text = "Place Order";
            this.placeOrderByPiece.UseVisualStyleBackColor = true;
            // 
            // addLineButton
            // 
            this.addLineButton.Location = new System.Drawing.Point(23, 120);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(95, 64);
            this.addLineButton.TabIndex = 3;
            this.addLineButton.Text = "Add to Order";
            this.addLineButton.UseVisualStyleBackColor = true;
            // 
            // deliveryTypeByPrint
            // 
            this.deliveryTypeByPrint.FormattingEnabled = true;
            this.deliveryTypeByPrint.Items.AddRange(new object[] {
            "One Hour",
            "Next Day"});
            this.deliveryTypeByPrint.Location = new System.Drawing.Point(286, 42);
            this.deliveryTypeByPrint.Name = "deliveryTypeByPrint";
            this.deliveryTypeByPrint.Size = new System.Drawing.Size(121, 33);
            this.deliveryTypeByPrint.TabIndex = 2;
            // 
            // qtyByPrint
            // 
            this.qtyByPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyByPrint.Location = new System.Drawing.Point(177, 42);
            this.qtyByPrint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyByPrint.Name = "qtyByPrint";
            this.qtyByPrint.Size = new System.Drawing.Size(76, 31);
            this.qtyByPrint.TabIndex = 1;
            this.qtyByPrint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // photoSizeByPrint
            // 
            this.photoSizeByPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoSizeByPrint.FormattingEnabled = true;
            this.photoSizeByPrint.Items.AddRange(new object[] {
            "4x6",
            "5x7",
            "8x10"});
            this.photoSizeByPrint.Location = new System.Drawing.Point(23, 42);
            this.photoSizeByPrint.Name = "photoSizeByPrint";
            this.photoSizeByPrint.Size = new System.Drawing.Size(121, 33);
            this.photoSizeByPrint.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "6270 Photo Kiosk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(44, 381);
            this.receiptLabel.MaximumSize = new System.Drawing.Size(400, 400);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(0, 24);
            this.receiptLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 636);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyStandard)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qtyByPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button placeOrderStandard;
        private System.Windows.Forms.ComboBox deliveryTypeStandard;
        private System.Windows.Forms.ComboBox photoTypeStandard;
        private System.Windows.Forms.NumericUpDown qtyStandard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PromoLabel;
        private System.Windows.Forms.TextBox promoCodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deliveryTypeByPrint;
        private System.Windows.Forms.NumericUpDown qtyByPrint;
        private System.Windows.Forms.ComboBox photoSizeByPrint;
        private System.Windows.Forms.Button clearOrder;
        private System.Windows.Forms.Button placeOrderByPiece;
        private System.Windows.Forms.Button addLineButton;
        private System.Windows.Forms.ComboBox finishStandard;
        private System.Windows.Forms.Label receiptLabel;
    }
}

