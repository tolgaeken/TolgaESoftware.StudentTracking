using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls
{
     [ToolboxItem(true)]
    public class MyDataLayoutControl:DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;
        }

        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {
        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            item.AppearanceItemCaption.Options.UseTextOptions = true;
            item.AppearanceItemCaption.Font = new Font("Tahoma",8.25f,FontStyle.Bold );
            item.TextToControlDistance = 10;
            return item;
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var group = base.CreateLayoutGroup(parent);
            group.LayoutMode = LayoutMode.Table;
            group.Name = "layoutControlGroup";

            group.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            group.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            group.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            group.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition
            {
                SizeType = SizeType.Absolute,
                Width = 100,
            });

            group.OptionsTableLayoutGroup.RowDefinitions.Clear();
            for (int i = 0; i < 9; i++)
            {
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24,
                });
                if (i+1!=9) continue;
                group.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Percent,
                    Height = 85,
                });
            }

            return group;
        }
    }
}