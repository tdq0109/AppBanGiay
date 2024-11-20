using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("NHANVIEN")]
public partial class Nhanvien
{
    [Key]
    [Column("ID_NHANVIEN")]
    public int IdNhanvien { get; set; }

    [Column("HOVATEN")]
    [StringLength(50)]
    public string? Hovaten { get; set; }

    [Column("GIOITINH")]
    [StringLength(5)]
    public string? Gioitinh { get; set; }

    [Column("SDT")]
    public int? Sdt { get; set; }

    [Column("DIACHI")]
    [StringLength(50)]
    public string? Diachi { get; set; }

    [Column("ID_CHUCVU")]
    public int? IdChucvu { get; set; }

    [Column("NGAYSINH")]
    public DateOnly? Ngaysinh { get; set; }

    [Column("MATKHAU")]
    [StringLength(50)]
    public string? Matkhau { get; set; }

    [ForeignKey("IdChucvu")]
    [InverseProperty("Nhanviens")]
    public virtual Chucvu? IdChucvuNavigation { get; set; }
}
