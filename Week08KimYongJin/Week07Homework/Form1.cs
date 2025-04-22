using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Homework
{
    public partial class Form1: Form
    {
        List<Product> products;
        Random random = new Random();
        Label[] lblSearchs;
        public Form1()
        {
            InitializeComponent();
            
            products = new List<Product>(); // 새로운 List 생성 () 값까지 선언해야함.
            lblSearchs = new Label[]
            {
               lblSearchProductCode,
               lblSearchProductName,
               lblSearchProductPrice,
               lblSearchProductRegDate,
               lblSearchProductSalePrice,
               lblSearchProductStock,
               lblSearchProductTotalPrice
            };
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(tbxInputProductName.Text == null)
            {
                MessageBox.Show("상품의 이름을 입력해 주세요.");
                tbxInputProductName.Focus();
                return;
            }
            else if(tbxInputProductPrice.Text == null)
            {
                MessageBox.Show("상품의 가격을 입력해 주세요.");
                tbxInputProductPrice.Focus();
                return;
            }
            else if (tbxInputProductStock.Text == null)
            {
                MessageBox.Show("상품의 재고를 입력해 주세요.");
                tbxInputProductStock.Focus();
                return;
            }
            // 리스트는 크기 제한이 없다. 같은 상품을 또 올려도 될 거 같다. 
            Product product = new Product();
            product.Name = tbxInputProductName.Text;
            product.Price = int.Parse(tbxInputProductPrice.Text); 
            product.Stock = int.Parse(tbxInputProductStock.Text);
            product.RegDate = DateTime.Now.AddDays(-random.Next(20, 100));
            
            string code = "";
            bool duplication;

            do
            {
                code = DateTime.Now.ToString("yyyyMMdd") + random.Next(0, 1000).ToString("D3");
                duplication = false;
                foreach (Product product1 in products)
                {
                    if (product1.Code == code)
                    {
                        duplication = true;
                        break;
                    }

                }
            } while (duplication);
            product.Code = code;
            products.Add(product);
            MessageBox.Show("등록완료");
            productClear();
            SearchClear();
        }

        private void productClear()
        {
            tbxInputProductName.Text = "";
            tbxInputProductPrice.Text = "";
            tbxInputProductStock.Text = "";
        }
        private void SearchClear()
        {
            foreach(Label label in lblSearchs)
            {
                label.Text = "";
            }
            tbxSearchProcuctCount.Text = "";
        }
        private void setSearch(Product target)
        {
            lblSearchProductCode.Text = target.Code;
            lblSearchProductName.Text = target.Name;
            lblSearchProductPrice.Text = target.Price.ToString();
            lblSearchProductRegDate.Text = target.RegDate.ToString("yyyy-MM-dd");
            lblSearchProductSalePrice.Text = target.SalePrice().ToString();
            lblSearchProductStock.Text = target.Stock.ToString();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchClear();
            lbxSearchProduct.Items.Clear();
            bool found = false;
            // 코드 혹은 이름의 일부분만 입력하면 products에서 일치하는 요소 출력.
            foreach(Product product in products)
            {
                if (product.Code.Contains(tbxSearchNameCode.Text) || product.Name.Contains(tbxSearchNameCode.Text))
                {
                    lbxSearchProduct.Items.Add(product);
                    found = true;
                }
            }
            if(found == false)
            {
                MessageBox.Show("해당 상품이 없습니다.");
                tbxSearchNameCode.Focus();
                return;
            }
        }

        private void lbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 내가 선택한 아이템 내용 우측 컨트롤 출력.
            // 등록일자는 yyyy-MM-dd 출력 할인가격은 SalePrice() 메소드 이용.
            var target = lbxSearchProduct.SelectedItem as Product;
            // 정보 삽입을 메소드로 할 수는 없을까?
            setSearch(target);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            var target = lbxSearchProduct.SelectedItem as Product;
            if (int.Parse(tbxSearchProcuctCount.Text) < 0 || int.Parse(tbxSearchProcuctCount.Text) > int.Parse(lblSearchProductStock.Text)) {
                MessageBox.Show("적합한 수량이 아닙니다.");
                tbxSearchProcuctCount.Focus();
                return;
            } 
            else
            {
                lblSearchProductTotalPrice.Text = target.CalPrice(int.Parse(tbxSearchProcuctCount.Text)).ToString();
            }

        }
    }
}
