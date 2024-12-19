using Project.BLL.DesignPattern.ServicePattern.ConcServices;
using Project.BLL.Dtos.Categories;
using Project.WinUI.VmClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {

        CategoryService _catService;
        public Form1()
        {
            InitializeComponent();
            _catService = new CategoryService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCategoryVM cvm = new CreateCategoryVM()
            {
                CategoryName = "Tatlılar",
                Description = "Deneme"
            };

            CreateCategoryDto cDto = new CreateCategoryDto()
            {
                CategoryName = cvm.CategoryName,
                Description = cvm.Description
            };

            _catService.Add(cDto);
        }
    }
}
