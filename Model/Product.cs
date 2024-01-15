using System;
using System.Collections.Generic;

namespace demopract2024_2.Model;

public partial class Product
{
    public string ProductArticleNumber { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public int ProductCategory { get; set; }

    public int ProductManufacturer { get; set; }

    public int ProductSupplier { get; set; }

    public decimal ProductCost { get; set; }

    public sbyte? ProductDiscountAmount { get; set; }

    public int ProductQuantityInStock { get; set; }

    public string? ProductUnit { get; set; }

    public string? ProductPhoto { get; set; }
    public string ProductPhotoGet { get { return ProductPhoto != null ? $"/Resources/Image/{ProductPhoto}" : null; } }

	public virtual ICollection<Orderproduct> Orderproducts { get; } = new List<Orderproduct>();

    public virtual Category ProductCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer ProductManufacturerNavigation { get; set; } = null!;

    public virtual Supplier ProductSupplierNavigation { get; set; } = null!;
}
