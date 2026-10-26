namespace  
 HotelManagement.Phong  
{  
    
 partial  
 class  
 FormDanhSachPhong  
    
 {  
        
   
        
 private  
 System.ComponentModel.
 IContainer  
 components = 
 null
 ;  
 
        
   
        
   
        
 protected  
 override  
 void  
 Dispose
 (
 bool  
 disposing
 )  
        
 {  
            
 if  
 (
 disposing  
 && (components != 
 null
 ))  
            
 {  
                
 components.
 Dispose
 ();  
            
 }  
            
 base
 .
 Dispose
 (
 disposing
 );  
        
 }  
 
        
 
        
   
        
 private  
 void  
 InitializeComponent
 ()  
        
 {  
            
 this
 .txtTimKiem = 
 new 
 System.Windows.Forms.
 TextBox
 ();  
            
 this
 .btnXuatExcel = 
 new 
 System.Windows.Forms.
 Button
 ();  
            
 this
 .btnThemMoiPhong = 
 new 
 System.Windows.Forms.
 Button
 ();  
            
 this
 .dtgDanhSachPhong = 
 new 
 System.Windows.Forms.
 DataGridView
 ();  
            
 this
 .pictureBox1 = 
 new 
 System.Windows.Forms.
 PictureBox
 ();  
            
((System.ComponentModel.
 ISupportInitialize
 )(
 this
 .dtgDanhSachPhong)).
 BeginInit
 ();  
            
 ((System.ComponentModel.
 ISupportInitialize
 )(
 this
 .pictureBox1)).
 BeginInit
 ();  
            
 this
 .
 SuspendLayout
 ();  
            

            
            
 this
 .txtTimKiem.Font = 
 new 
 System.Drawing.
 Font
 (
 "Microsoft Sans Serif"
 , 13F, 
System.Drawing.
 FontStyle
 .Regular, System.Drawing.
 GraphicsUnit
 .Point, ((
 byte
 )(0)));  
            
 this
 .txtTimKiem.Location = 
 new 
 System.Drawing.
 Point
 (130, 12);  
            
 this
 .txtTimKiem.Name = 
 "txtTimKiem"
 ;  
            
 this
 .txtTimKiem.Size = 
 new 
 System.Drawing.
 Size
 (187, 32);  
            
 this
 .txtTimKiem.TabIndex = 0;  
            
            
            
            
            
 this
 .btnXuatExcel.BackColor = System.Drawing.
 Color
 .DarkTurquoise;  
            
 this
 .btnXuatExcel.Font = 
 new 
 System.Drawing.
 Font
 (
 "Microsoft Sans Serif"
 , 
12F, System.Drawing.
 FontStyle
 .Bold, System.Drawing.
 GraphicsUnit
 .Point, ((
 byte
 )(0)));  
            
 this
 .btnXuatExcel.Location = 
 new 
 System.Drawing.
 Point
 (560, 12);  
            
 this
 .btnXuatExcel.Name = 
 "btnXuatExcel"
 ;  
            
 this
 .btnXuatExcel.Size = 
 new 
 System.Drawing.
 Size
 (167, 37);  
            
 this
 .btnXuatExcel.TabIndex = 2;  
            
 this
 .btnXuatExcel.Text = 
 "Xuất file Excel"
 ;  
            
 this
 .btnXuatExcel.UseVisualStyleBackColor = 
 false
 ;  
            
            
            
            
            
 this
 .btnThemMoiPhong.BackColor = System.Drawing.
 Color
 .MediumSpringGreen;  
            
 this
 .btnThemMoiPhong.Font = 
 new 
 System.Drawing.
 Font
 (
 "Microsoft Sans Serif"
 , 
12F, System.Drawing.
 FontStyle
 .Bold, System.Drawing.
 GraphicsUnit
 .Point, ((
 byte
 )(0)));  
            
 this
 .btnThemMoiPhong.Location = 
 new 
 System.Drawing.
 Point
 (803, 12);  
            
 this
 .btnThemMoiPhong.Name = 
 "btnThemMoiPhong"
 ;  
            
 this
 .btnThemMoiPhong.Size = 
 new 
 System.Drawing.
 Size
 (188, 37);  
            
 this
 .btnThemMoiPhong.TabIndex = 3;  
            
 this
 .btnThemMoiPhong.Text = 
 "Thêm mới phòng"
 ;  
            
 this
 .btnThemMoiPhong.UseVisualStyleBackColor = 
 false
 ;  
            
            
            
            
            
 this
 .dtgDanhSachPhong.ColumnHeadersHeightSizeMode = 
System.Windows.Forms.
 DataGridViewColumnHeadersHeightSizeMode
 .AutoSize;  
            
 this
 .dtgDanhSachPhong.Location = 
 new 
 System.Drawing.
 Point
 (12, 72);  
            
 this
 .dtgDanhSachPhong.Name = 
 "dtgDanhSachPhong"
 ;  
            
 this
 .dtgDanhSachPhong.RowHeadersWidth = 51;  
            
 this
 .dtgDanhSachPhong.RowTemplate.Height = 24;  
            
 this
 .dtgDanhSachPhong.Size = 
 new 
 System.Drawing.
 Size
 (1015, 615);  
            
 this
 .dtgDanhSachPhong.TabIndex = 4;  
            
            
            
            
            
 this
 .pictureBox1.Image = 
global
 ::HotelManagement.Properties.
 Resources
 .search;  
            
 this
 .pictureBox1.Location = 
 new 
 System.Drawing.
 Point
 (85, 7);  
            
 this
 .pictureBox1.Name = 
 "pictureBox1"
 ;  
            
 this
 .pictureBox1.Size = 
 new 
 System.Drawing.
 Size
 (39, 37);  
            
 this
 .pictureBox1.TabIndex = 1;  
            
 this
 .pictureBox1.TabStop = 
 false
 ;  
            
            
            
            
 this
 .AutoScaleDimensions = 
 new 
 System.Drawing.
 SizeF
 (8F, 16F);  
            
 this
 .AutoScaleMode = System.Windows.Forms.
 AutoScaleMode
 .Font;  
this
 .ClientSize = 
 new 
 System.Drawing.
 Size
 (1039, 699);  
            
 this
 .Controls.
 Add
 (
 this
 .dtgDanhSachPhong);  
            
 this
 .Controls.
 Add
 (
 this
 .btnThemMoiPhong);  
            
 this
 .Controls.
 Add
 (
 this
 .btnXuatExcel);  
            
 this
 .Controls.
 Add
 (
 this
 .pictureBox1);  
            
 this
 .Controls.
 Add
 (
 this
 .txtTimKiem);  
            
 this
 .Name = 
 "FormDanhSachPhong"
 ;  
            
 this
 .StartPosition = System.Windows.Forms.
 FormStartPosition
 .CenterScreen;  
            
 this
 .Text = 
 "Quản lý thông tin phòng"
 ;  
            
            
((System.ComponentModel.
 ISupportInitialize
 )(
 this
 .dtgDanhSachPhong)).
 EndInit
 ();  
            
 ((System.ComponentModel.
 ISupportInitialize
 )(
 this
 .pictureBox1)).
 EndInit
 ();  
            
 this
 .
 ResumeLayout
 (
 false
 );  
            
 this
 .
 PerformLayout
 ();  
 
        
 }  
 
        
   
 
        
 private  
 System.Windows.Forms.
 TextBox  
 txtTimKiem;  
        
 private  
 System.Windows.Forms.
 PictureBox  
 pictureBox1;  
        
 private  
 System.Windows.Forms.
 Button  
 btnXuatExcel;  
        
 private  
 System.Windows.Forms.
 Button  
 btnThemMoiPhong;  
        
 private  
 System.Windows.Forms.
 DataGridView  
 dtgDanhSachPhong;  
    
 }  
}
