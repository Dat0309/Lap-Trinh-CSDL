using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo18_08_2021.DTO;

namespace Demo18_08_2021
{
	public partial class frmMain : Form
	{
		private Contex context;
		private List<DiningTable> tableList;

		public frmMain(Contex context)
		{
			this.context = context;
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			LoginForm login = new LoginForm();
			if (login.ShowDialog() != DialogResult.OK)
			{
				Application.Exit();
			}

			tableList = new List<DiningTable>();
			Random r = new Random();
			for (int i = 1; i < 27; i++)
			{
				DiningTable table = new DiningTable();
				table.TableName = $"Bàn {i}";
				table.TableId = i;
				table.Status = r.Next(0, 2); // 0- Trống, 1- Có người
				table.Floor = r.Next(1, 4);

				tableList.Add(table);
			}

			LoadTableListFLP();
			//LoadTableListLv();
			//LoadTableToLvDetail();
		}

		private void LoadTableListFLP()
		{
			var floors = new[] {flpFloorOne, flpFloorTwo, flpFloorThree};
			foreach (var table in tableList)
			{
				Button btn = new Button();
				btn.Text = table.TableName + "\r\n" + (table.Status == 1 ? "Có người" : "Trống");
				btn.BackColor = table.Status == 1 ? Color.Orange: Color.Aquamarine;
				btn.Height = 40;
				btn.Width = 80;
				ttFloor.SetToolTip(btn, $"Tầng {table.Floor}");

				floors[table.Floor - 1].Controls.Add(btn);
			}
		}

		private void tsmiAdmin_Click(object sender, EventArgs e)
		{
			AdminForm form = new AdminForm(context);
			form.ShowDialog();
		}

		/*private void LoadTableListLv()
		{
			ListViewGroup floorOne = new ListViewGroup("Tầng 1", HorizontalAlignment.Center);
			ListViewGroup floorTwo = new ListViewGroup("Tầng 2", HorizontalAlignment.Center);
			ListViewGroup floorThree = new ListViewGroup("Tầng 3", HorizontalAlignment.Center);

			lvTableList.Groups.Add(floorOne);
			lvTableList.Groups.Add(floorTwo);
			lvTableList.Groups.Add(floorThree);

			var floorGroups = new[] {floorOne, floorTwo, floorThree};
			foreach (var table in tableList)
			{
				ListViewItem item = new ListViewItem(table.TableName, table.Status);

				item.Group = floorGroups[table.Floor - 1];
				lvTableList.Items.Add(item);
			}
		}

		private void LoadTableToLvDetail()
		{
			lvTableList.Items.Clear();
			foreach (var table in tableList)
			{
				ListViewItem item = new ListViewItem(table.TableId.ToString());
				item.SubItems.Add(table.TableName);
				item.SubItems.Add(table.Status == 1 ? "Có người" : "Trống");
				item.SubItems.Add(table.Floor.ToString());

				lvTableList.Items.Add(item);
			}
		}

		*/


	}
}
