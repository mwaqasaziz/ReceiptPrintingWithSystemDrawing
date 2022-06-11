using System.Drawing.Printing;

namespace ReceiptPrinting
{
    public partial class Form1 : Form
    {
        string printerName { get; set; }
        List<string> printerNames = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvPrint.Rows.Add("Prod 1", 5, 1.5, 7.5);
            DgvPrint.Rows.Add("Prod 1", 5, 1.5, 7.5);
            DgvPrint.Rows.Add("Prod 1", 5, 1.5, 7.5);
            DgvPrint.Rows.Add("Prod 1", 5, 1.5, 7.5);
            DgvPrint.Rows.Add("Prod 1", 5, 1.5, 7.5);
            DgvPrint.Rows.Add("Prod 1", 5, 1.5, 7.5);

            DgvPrint.Columns[DgvColAmount.Name].ValueType = typeof(decimal);
            DgvPrint.Columns[DgvColQ.Name].ValueType = typeof(decimal);
            DgvPrint.Columns[DgvColUnitRate.Name].ValueType = typeof(decimal);

            
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                printerNames.Add(printer);
            }

            ComBoxPrinters.DataSource = printerNames;
            
        }

        private void ComBoxPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            printerName = printerNames[ComBoxPrinters.SelectedIndex];
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();

            printDoc.DefaultPageSettings.PaperSize = new PaperSize("Custom", 257, 0);
            printDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            printDoc.PrinterSettings.PrinterName = printerName;

            printDoc.PrintPage += PrintDoc_PrintPage;
            printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics != null)
            {
                Graphics graphic = e.Graphics;

                int left = 10;
                int cellLeft = left;
                int offSet = 0;
                Rectangle rect;

                Font font = new Font("tahoma", 9);
                Pen p = new Pen(Brushes.Black, 1f);

                StringFormat stringFormatCenter = new StringFormat();
                stringFormatCenter.Alignment = StringAlignment.Center;
                stringFormatCenter.LineAlignment = StringAlignment.Center;

                StringFormat stringFormatRight = new StringFormat();
                stringFormatRight.Alignment = StringAlignment.Far;
                stringFormatRight.LineAlignment = StringAlignment.Center;

                StringFormat stringFormatLeft = new StringFormat();
                stringFormatLeft.LineAlignment = StringAlignment.Center;

                //Business Logo
                //Bitmap Logo = new Bitmap(Resources.PapaPan);
                //graphic.DrawImage(Logo, new Rectangle(150, offSet, 100, 100));

                graphic.DrawString("Inv No: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet, 150, 20));
                graphic.DrawString("Invoice Number Here", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left, offSet + 20, 150, 20));
                graphic.DrawString("Inv Date: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet + 40, 150, 20));
                graphic.DrawString(DateTime.Now.ToString("MM-dd-yyyy"), new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left, offSet + 60, 150, 20));
                graphic.DrawString("Inv Time: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet + 80, 150, 20));
                graphic.DrawString(DateTime.Now.ToString("HH:mm:ss") , new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left, offSet + 100, 150, 20));

                offSet += 120;

                graphic.DrawLine(p, new Point(left, offSet), new Point(left + 260, offSet));

                offSet += 5;

                graphic.DrawString("Customer Details ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, left, offSet);

                offSet += 20;

                graphic.DrawString("ID: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet, 65, 20), stringFormatRight);
                graphic.DrawString("Customer Id Here", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 65, offSet, e.PageSettings.PaperSize.Width - (left + 50), 20), stringFormatLeft);

                offSet += 20;

                graphic.DrawString("Name: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet, 65, 20), stringFormatRight);
                graphic.DrawString("Customer Name Here", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 65, offSet, e.PageSettings.PaperSize.Width - (left + 50), 20), stringFormatLeft);

                offSet += 20;

                graphic.DrawString("Ph No: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet, 65, 20), stringFormatRight);
                graphic.DrawString("Phone Number Here", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 65, offSet, e.PageSettings.PaperSize.Width - (left + 50), 20), stringFormatLeft);

                offSet += 20;

                string address = string.Empty;

                //Limiting the address to 31 characters
                //if (TxtCustAddress.Text.Length > 31)
                //    address = TxtCustAddress.Text.Remove(31);
                //else
                //    address = TxtCustAddress.Text;

                graphic.DrawString("Address: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet, 65, 20), stringFormatRight);
                graphic.DrawString(address, new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left + 65, offSet, e.PageSettings.PaperSize.Width - (left + 50), 20), stringFormatLeft);

                offSet += 20;

                graphic.DrawLine(p, new Point(left, offSet), new Point(left + 260, offSet));

                offSet += 5;

                graphic.DrawString("Products Details ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, left, offSet);

                offSet += 20;

                cellLeft = left;
                foreach (DataGridViewColumn dgvColumn in DgvPrint.Columns)
                {

                    rect = new Rectangle(cellLeft, offSet, dgvColumn.Width, DgvPrint.ColumnHeadersHeight);
                    graphic.FillRectangle(Brushes.LightGray, rect);
                    graphic.DrawString(dgvColumn.HeaderText.ToString(), font, Brushes.Black, rect, stringFormatCenter);
                    graphic.DrawRectangle(p, rect);
                    cellLeft += dgvColumn.Width;
                }

                foreach (DataGridViewRow dgvRow in DgvPrint.Rows)
                {
                    cellLeft = left;
                    offSet += dgvRow.Height;
                    foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                    {
                        rect = new Rectangle(cellLeft, offSet, dgvCell.Size.Width, dgvCell.Size.Height);
                        if (dgvCell.ValueType.Equals(typeof(decimal)))
                            graphic.DrawString(dgvCell.FormattedValue.ToString(), new Font("Tahoma", 8f), Brushes.Black, rect, stringFormatRight);
                        else
                            graphic.DrawString(dgvCell.FormattedValue.ToString(), new Font("Tahoma", 8f), Brushes.Black, rect, stringFormatLeft);
                        cellLeft += dgvCell.Size.Width;
                    }
                }
                //If there is Discount
                if (Convert.ToDecimal("0.0") > 0)
                {
                    offSet += DgvPrint.Rows[0].Height;
                    graphic.DrawLine(p, new Point(left, offSet), new Point(left + 210, offSet));

                    graphic.DrawString("Discount: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(
                                                                                                                             left,
                                                                                                                             offSet,
                                                                                                                             DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                           + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                           + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                             DgvPrint.Rows[0].Height
                                                                                                                          ), stringFormatRight);
                    graphic.DrawString((-Convert.ToDecimal("0.0")).ToString("N0"), new Font("Tahoma", 9f), Brushes.Black, new Rectangle(
                                                                                                                                                                 left
                                                                                                                                                               + DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                                                               + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                                                               + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                                                                 offSet,
                                                                                                                                                                 DgvPrint.Rows[0].Cells[3].Size.Width,
                                                                                                                                                                 DgvPrint.Rows[0].Height
                                                                                                                                                              ), stringFormatRight);
                }

                //in case of delivery charges
                if (Convert.ToDecimal("6") > 0)
                {
                    offSet += DgvPrint.Rows[0].Height;
                    if (Convert.ToDecimal("0.0") == 0)
                        graphic.DrawLine(p, new Point(left, offSet), new Point(left + 210, offSet));

                    graphic.DrawString("Delivery charges: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(
                                                                                                                                     left,
                                                                                                                                     offSet,
                                                                                                                                     DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                                   + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                                   + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                                     DgvPrint.Rows[0].Height
                                                                                                                                  ), stringFormatRight);
                    graphic.DrawString("6", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(
                                                                                                                             left
                                                                                                                           + DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                           + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                           + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                             offSet,
                                                                                                                             DgvPrint.Rows[0].Cells[3].Size.Width,
                                                                                                                             DgvPrint.Rows[0].Height
                                                                                                                          ), stringFormatRight);
                }

                offSet += DgvPrint.Rows[0].Height;
                graphic.DrawLine(p, new Point(left + 210, offSet), new Point(left + 260, offSet));

                graphic.DrawString("Net Amount: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(
                                                                                                                           left,
                                                                                                                           offSet,
                                                                                                                           DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                         + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                         + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                           DgvPrint.Rows[0].Height
                                                                                                                        ), stringFormatRight);
                graphic.DrawString("51", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(
                                                                                                              left
                                                                                                            + DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                            + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                            + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                              offSet,
                                                                                                              DgvPrint.Rows[0].Cells[3].Size.Width,
                                                                                                              DgvPrint.Rows[0].Height
                                                                                                           ), stringFormatRight);

                offSet += DgvPrint.Rows[0].Height;

                graphic.DrawString("Payment: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(
                                                                                                                                 left,
                                                                                                                                 offSet,
                                                                                                                                 DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                               + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                               + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                                 DgvPrint.Rows[0].Height
                                                                                                                              ), stringFormatRight);
                graphic.DrawString("60", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(
                                                                                                                     left
                                                                                                                   + DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                   + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                   + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                     offSet,
                                                                                                                     DgvPrint.Rows[0].Cells[3].Size.Width,
                                                                                                                     DgvPrint.Rows[0].Height
                                                                                                                  ), stringFormatRight);

                offSet += DgvPrint.Rows[0].Height;
                graphic.DrawLine(p, new Point(left + 210, offSet), new Point(left + 260, offSet));

                graphic.DrawString("Balance: ", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(
                                                                                                                           left,
                                                                                                                           offSet,
                                                                                                                           DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                         + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                         + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                           DgvPrint.Rows[0].Height
                                                                                                                        ), stringFormatRight);
                graphic.DrawString("9", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(
                                                                                                                    left
                                                                                                                  + DgvPrint.Rows[0].Cells[0].Size.Width
                                                                                                                  + DgvPrint.Rows[0].Cells[1].Size.Width
                                                                                                                  + DgvPrint.Rows[0].Cells[2].Size.Width,
                                                                                                                    offSet,
                                                                                                                    DgvPrint.Rows[0].Cells[3].Size.Width,
                                                                                                                    DgvPrint.Rows[0].Height
                                                                                                                 ), stringFormatRight);
                offSet += DgvPrint.Rows[0].Height;
                graphic.DrawLine(p, new Point(left + 210, offSet), new Point(left + 260, offSet));
                offSet += 3;
                graphic.DrawLine(p, new Point(left + 210, offSet), new Point(left + 260, offSet));

                offSet += 5;

                graphic.DrawString("Thanks for visiting", new Font("Tahoma", 9f, FontStyle.Bold), Brushes.Black, new Rectangle(left, offSet, e.PageSettings.PaperSize.Width, 20), stringFormatCenter);

                offSet += 20;

                graphic.DrawString("facebook address", new Font("Tahoma", 9f), Brushes.Black, new Rectangle(left, offSet, e.PageSettings.PaperSize.Width, 20), stringFormatCenter);

                offSet += 20;

                graphic.DrawRectangle(p, new Rectangle(left, offSet, e.PageSettings.PaperSize.Width, 35));

                //Bitmap MABLogo = new Bitmap(Resources.MabPrint);
                //graphic.DrawImage(MABLogo, new Rectangle(left + 25, offSet + 5, 38, 25));


                graphic.DrawString("Business Name", new Font("Tahoma", 7f), Brushes.Black, new Rectangle(left + 75, offSet + 2, e.PageSettings.PaperSize.Width - 80, 10), stringFormatCenter);
                graphic.DrawString("Phone Number", new Font("Tahoma", 7f), Brushes.Black, new Rectangle(left + 75, offSet + 12, e.PageSettings.PaperSize.Width - 80, 10), stringFormatCenter);
                graphic.DrawString("Email", new Font("Tahoma", 7f), Brushes.Black, new Rectangle(left + 75, offSet + 22, e.PageSettings.PaperSize.Width - 80, 10), stringFormatCenter);

                //graphic.DrawString("Muhammad Waqas Aziz", new Font("Tahoma", 12f, FontStyle.Bold), Brushes.Black, new Rectangle(10, offSet, e.PageSettings.PaperSize.Width-10, 40), stringFormatCenter);
            }
        }

        
    }
}