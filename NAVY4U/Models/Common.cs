﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NAVY4U.Models;

namespace NAVY4U.Models
{
    public class Common
    {
        static DbContext db = new DbContext("name=BanHangOnlineEntities");
        /// <summary>
        /// Lấy danh sách tất cả sản phẩm
        /// </summary>
        /// <returns></returns>
        public static List<sanPham> getsanPhams()
        {
            return db.Set<sanPham>().ToList<sanPham>();
        }
        /// <summary>
        /// Lấy danh sách sản phẩm thuộc 1 loại hàng nào đó
        /// </summary>
        /// <param name="maLoai"></param>
        /// <returns></returns>
        public static List<sanPham> getsanPhamsById(int maLoai)
        {
            List<sanPham> sanPhams = new List<sanPham>();
            sanPhams = db.Set<sanPham>().Where(x => x.maLoai == maLoai).ToList<sanPham>();
            return sanPhams;
        }
        /// <summary>
        /// Lấy danh sách các loại hàng
        /// </summary>
        /// <returns></returns>
        public static List<loaiSP> getCategories()
        {
            return db.Set<loaiSP>().ToList<loaiSP>();
        }
        /// <summary>
        /// Lấy thông tin 1 sản phẩm dựa vào mã sản phẩm
        /// </summary>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public static sanPham getsanPhamById(string maSP)
        {
            return db.Set<sanPham>().Find(maSP);
        }

        public static string getNameSanPhamById(string maSP)
        {
            return db.Set<sanPham>().Find(maSP).tenSP;
        }
        public static string getImageSanPhamById(string maSP)
        {
            return db.Set<sanPham>().Find(maSP).hinhDD;
        }
        /// <summary>
        /// Lấy ra n bài viết mới nhất từ database 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<baiViet> getArticles(int n)
        {
            List<baiViet> l = new List<baiViet>();
            BanHangOnlineEntities db = new BanHangOnlineEntities();
            l = db.baiViets.OrderByDescending(bv => bv.ngayDang).Take(n).ToList<baiViet>();
            return l;
        }

    }
}