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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Globalization;

namespace WpfTree
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            string _json_str = @"{
    ""glossary"": {
        ""title"": ""example glossary"",
		""GlossDiv"": {
            ""title"": ""S"",
			""GlossList"": {
                ""GlossEntry"": {
                    ""ID"": ""SGML"",
					""SortAs"": ""SGML"",
					""GlossTerm"": ""Standard Generalized Markup Language"",
					""Acronym"": ""SGML"",
					""Abbrev"": ""ISO 8879:1986"",
					""GlossDef"": {
                        ""para"": ""A meta-markup language, used to create markup languages such as DocBook."",
						""GlossSeeAlso"": [""GML"", ""XML""]
                    },
					""GlossSee"": ""markup""
                }
            }
        }
    }
}";
            object _json_obj = Newtonsoft.Json.JsonConvert.DeserializeObject(_json_str);


            var token =  Newtonsoft.Json.Linq.JToken.Parse(_json_str);

            var children = new List<Newtonsoft.Json.Linq.JToken>();
            if (token != null)
            {
                children.Add(token);
            }

            treeView1.ItemsSource = null;
            treeView1.Items.Clear();
            treeView1.ItemsSource = children;
        }
    }
}
