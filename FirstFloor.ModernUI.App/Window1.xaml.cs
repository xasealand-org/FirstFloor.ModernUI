using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FirstFloor.ModernUI.App
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void win_LoadedEvent(object sender, RoutedEventArgs e)
        {
            foreach (FontFamily _f in Fonts.SystemFontFamilies)
            {
                LanguageSpecificStringDictionary _fontDic = _f.FamilyNames;
                string _fontName = null;
                if (_fontDic.ContainsKey(XmlLanguage.GetLanguage("zh-cn")))
                {
                    if (_fontDic.TryGetValue(XmlLanguage.GetLanguage("zh-cn"), out _fontName))
                    {
                        cbo_Demo.Items.Add(_fontName);
                    }
                }
                else if (_fontDic.ContainsKey(XmlLanguage.GetLanguage("en-us")))
                {
                    if (_fontDic.TryGetValue(XmlLanguage.GetLanguage("en-us"), out _fontName))
                    {
                        cbo_Demo.Items.Add(_fontName);
                    }
                }
            }
        }
    }
}
