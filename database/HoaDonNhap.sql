SELECT DISTINCT MaNCC 
FROM HoaDon_NhapHang
WHERE MaNCC NOT IN (SELECT MaNCC FROM NhaCungCap);

DELETE FROM HoaDon_NhapHang
WHERE MaNCC NOT IN (SELECT MaNCC FROM NhaCungCap);

DELETE FROM ChiTiet_NhapHang
WHERE MaHD_NhapHang IN (
    SELECT MaHD_NhapHang 
    FROM HoaDon_NhapHang
    WHERE MaNCC NOT IN (SELECT MaNCC FROM NhaCungCap)
);

DELETE FROM HoaDon_NhapHang
WHERE MaNCC NOT IN (SELECT MaNCC FROM NhaCungCap);

select * from HangHoa;
select * from NhaCungCap;
select * from ChiTiet_NhapHang;
select * from HoaDon_NhapHang;

insert into ChiTiet_NhapHang values 
('15', 'Nhap11', '10', '10000000', ''),
('20', 'Nhap12', '20', '20000000', ''),
('15', 'Nhap01', '11', '127637', '');

insert into HoaDon_NhapHang values
('Nhap11', '1', '2025-08-12', '', '1'),
('nhap12', '2', '2025-10-12', '', '1'),
('nhap01', '2', '2024-11-11', '', '1');

alter table ChiTiet_NhapHang
add constraint Db_GhiChu default N'' for GhiChu;