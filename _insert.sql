--DanToc
insert into DanToc(MaDanToc,TenDanToc)
	values('01',N'Kinh');
insert into DanToc(MaDanToc,TenDanToc)
	values('02',N'Tày');
insert into DanToc(MaDanToc,TenDanToc)
	values('03',N'Thái');
insert into DanToc(MaDanToc,TenDanToc)
	values('05',N'Khơ-me');
insert into DanToc(MaDanToc,TenDanToc)
	values('06',N'Mường');

--HeDaoTao
insert into HeDaoTao(MaHDT,TenHDT)
	values('hdt01',N'Chính quy');
insert into HeDaoTao(MaHDT,TenHDT)
	values('hdt02',N'Văn bằng 2');
insert into HeDaoTao(MaHDT,TenHDT)
	values('hdt03',N'Liên thông');
	
--Khoa
insert into Khoa(MaKhoa,TenKhoa,DienThoai,DiaChi,Website)
	values ('7340405',N'Hệ thống thông tin quản lý','02438526419',N'Phòng 604-Toà nhà A2','mis.hvnh.edu.vn');
insert into Khoa(MaKhoa,TenKhoa,DienThoai,DiaChi,Website)
	values ('7340120',N'Kinh doanh quốc tế','0435773383',N'Phòng 201-Toà nhà A2','kdqt.hvnh.edu.vn');
insert into Khoa(MaKhoa,TenKhoa,DienThoai,DiaChi,Website)
	values ('7340101',N'Quản trị kinh doanh','0437889696',N'Phòng 401-Toà nhà A2','qtkd.hvnh.edu.vn');
insert into Khoa(MaKhoa,TenKhoa,DienThoai,DiaChi,Website)
	values ('7340301',N'Kế toán-Kiểm toán','02438526412',N'Phòng 501-Toà nhà A2','ktkt.hvnh.edu.vn');

--ChucVu
insert into ChucVu(MaChucVu,TenChucVu)
	values ('cv01',N'Lớp trưởng'); 
insert into ChucVu(MaChucVu,TenChucVu)
	values ('cv02',N'Lớp phó');
insert into ChucVu(MaChucVu,TenChucVu)
	values ('cv03',N'Bí thư');
insert into ChucVu(MaChucVu,TenChucVu)
	values ('cv04',N'Thành viên');

--Que
insert into Que(MaQue,TenQue)
	values('01',N'Hà Nội');
insert into Que(MaQue,TenQue)
	values('29',N'Nghệ An');
insert into Que(MaQue,TenQue)
	values('26',N'Thái Bình');
insert into Que(MaQue,TenQue)
	values('25',N'Nam Định');
insert into Que(MaQue,TenQue)
	values('03',N'Hải Phòng');
insert into Que(MaQue,TenQue)
	values('28',N'Thanh Hóa');

--Lop
insert into Lop(MaLop,TenLop,MaKhoa,KhoaHoc,SiSo)
	values('K21HTTTA',N'K21 Hệ thống thông tin A','7340405','K21',4);
insert into Lop(MaLop,TenLop,MaKhoa,KhoaHoc,SiSo) 
	values('K21KDQTD',N'K21 Kinh doanh quốc tế D','7340120','K21',1);
insert into Lop(MaLop,TenLop,MaKhoa,KhoaHoc,SiSo) 
	values('K21KTDNC',N'K21 Kế toán doanh nghiệp C','7340301','K21',2);
insert into Lop(MaLop,TenLop,MaKhoa,KhoaHoc,SiSo) 
	values('K21QTMB',N'K21 Quản trị Marketing B','7340101','K21',1);
insert into Lop(MaLop,TenLop,MaKhoa,KhoaHoc,SiSo) 
	values('K21HTTTB',N'K21 Hệ thống thông tin B','7340405','K21',2);

--MonHoc
insert into MonHoc(MaMon,TenMon,DVHT)
	values('IS01A',N'Tin học đại cương',3);
insert into MonHoc(MaMon,TenMon,DVHT)
	values('PLT05A',N'Những nguyên lý cơ bản của Chủ nghĩa Mác - Lênin I',2);
insert into MonHoc(MaMon,TenMon,DVHT)
	values('SPT03A',N'Giáo dục thể chất II (Bóng rổ)',1);
insert into MonHoc(MaMon,TenMon,DVHT)
	values('ECO01A',N'Kinh tế vi mô',3);
insert into MonHoc(MaMon,TenMon,DVHT)
	values('IS03A',N'Kiến trúc máy tính và hệ điều hành',3);

--PhongHoc
insert into PhongHoc(MaPhong,TenPhong)
	values('P01','D1.202');
insert into PhongHoc(MaPhong,TenPhong)
	values('P02','D6.202');
insert into PhongHoc(MaPhong,TenPhong)
	values('P03','D5.102');
insert into PhongHoc(MaPhong,TenPhong)
	values('P04','D3.104');
insert into PhongHoc(MaPhong,TenPhong)
	values('P05','D4.202');
insert into PhongHoc(MaPhong,TenPhong)
	values('P06','D2.203');

---ChuyenNganh
insert into ChuyenNganh(MaChuyenNganh,TenChuyenNganh,MaKhoa)
	values('7340405',N'Hệ thống thông tin quản lý','7340405');
insert into ChuyenNganh(MaChuyenNganh,TenChuyenNganh,MaKhoa)
	values('7340405_J',N'Công nghệ và hệ thống thông tin Việt Nhật','7340405');
insert into ChuyenNganh(MaChuyenNganh,TenChuyenNganh,MaKhoa)
	values('7340120',N'Kinh doanh quốc tế','7340120');
insert into ChuyenNganh(MaChuyenNganh,TenChuyenNganh,MaKhoa)
	values('7340301',N'Kế toán doanh nghiệp','7340301');
insert into ChuyenNganh(MaChuyenNganh,TenChuyenNganh,MaKhoa)
	values('7340301_J',N'Kế toán Việt Nhật','7340301');
insert into ChuyenNganh(MaChuyenNganh,TenChuyenNganh,MaKhoa)
	values('7340101_M',N'Quản trị Marketing','7340101');
insert into ChuyenNganh(MaChuyenNganh,TenChuyenNganh,MaKhoa)
	values('7340101_D',N'Quản trị doanh nghiệp','7340101');

--Thoi_Khoa_Bieu
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTA','IS01A',1,N'Ba',3,'P02');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTA','IS01A',1,N'Sáu',4,'P03');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21KDQTD','ECO01A',2,N'Hai',2,'P03');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21KDQTD','ECO01A',2,N'Tư',3,'P04');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21QTMB','PLT05A',1,N'Ba',2,'P06');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21QTMB','PLT05A',1,N'Bảy',1,'P01');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTB','IS03A',5,N'Hai',3,'P04');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTB','IS03A',5,N'Năm',2,'P03');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21KTDNC','SPT03A',3,N'Tư',4,'P01');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21KTDNC','SPT03A',3,N'Năm',3,'P06');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTB','PLT05A',1,N'Hai',3,'P05');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTB','PLT05A',1,N'Năm',1,'P02');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTA','ECO01A',3,N'Ba',2,'P04');
insert into Thoi_Khoa_Bieu(MaLop,MaMon,HocKy,ThuHoc,CaHoc,MaPhong)
output inserted.id
	values('K21HTTTA','ECO01A',3,N'Sáu',4,'P03');
	

--SinhVien
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4040035',N'Nguyễn Thu Hoài','7340405','K21HTTTA','11/29/2000',N'Nữ','01','01','7340405','hdt01','cv04');--HTTT
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4040117',N'Đoàn Thị Huyền Trang','7340405','K21HTTTA','01/11/2000',N'Nữ','01','01','7340405','hdt01','cv04');
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A40400079',N'Đinh Thanh Ngọc','7340405','K21HTTTA','05/04/2000',N'Nữ','01','01','7340405','hdt01','cv04');
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4040010',N'Nguyễn Tuấn Chung','7340405','K21HTTTB','06/20/2000',N'Nam','03','01','7340405','hdt01','cv04');
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4040113',N'Nguyễn Thị Thanh Trà','7340405','K21HTTTA','09/01/2000',N'Nữ','29','01','7340405','hdt01','cv04');
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4030274',N'Trần Thị Hòa','7340101','K21QTMB','05/05/2000',N'Nữ','25','06','7340101_M','hdt01','cv01');--quản trị marketing
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4030241',N'Nguyễn Thế Đạt','7340101','K21QTMB','08/10/2000',N'Nam','26','03','7340101_M','hdt01','cv02');
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4020495',N'Lại Minh Sơn','7340301','K21KTDNC','03/15/2000',N'Nam','25','02','7340301','hdt01','cv02');---kế toán///
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4050213',N'Lê Thị Minh Hương','7340120','K21KDQTD','10/15/2000',N'Nữ','03','02','7340120','hdt01','cv03');---kinh doanh quốc tế////
insert into SinhVien(MaSV,TenSV,MaKhoa,MaLop,NgaySinh,GioiTinh,MaQue,MaDanToc,MaChuyenNganh,MaHDT,MaChucVu)
	values('21A4050472',N'Dương Mỹ Uyên','7340120','K21KDQTD','01/20/2000',N'Nữ','28','06','7340120','hdt01','cv01');---kinh doanh quốc tế////