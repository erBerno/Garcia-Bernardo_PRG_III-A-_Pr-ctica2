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

namespace Garcia_Bernardo_PRG_III__A__Práctica2
{
    /// <summary>
    /// Realizar un programa en C# que resuelva el siguiente problema.
    /// Una empresa dedicada a la elaboración de comida que será distribuida a domicilio desea presentar a sus clientes una aplicación que les 
    /// permita seleccionar de un menúposibles platos dados ciertos ingredientes. Por ejemplo, el cliente puede requerir platos que contengan carne, 
    /// pero no papas yotrosplatos que contenganverdura y arroz.En ambos casos, los platos pueden contener además otros ingredientes no mencionados 
    /// por el cliente.Además, cada plato tiene asociado un precio, por lo que luego de la selección deplatos y las cantidades requeridas podrá conocer 
    /// el total a pagar.
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> platos = new List<Plato>();
        List<Ingrediente> ingDsiponibles = new List<Ingrediente>()
        {
                new Ingrediente("Tomate"),
                new Ingrediente("Cebolla"),
                new Ingrediente("Lechuga"),
                new Ingrediente("Tocino"),
                new Ingrediente("Queso"),
                new Ingrediente("Pepinillos"),
                new Ingrediente("Queso"),
                new Ingrediente("Carne"),
                new Ingrediente("Papas"),
                new Ingrediente("Choclitos"),
                new Ingrediente("Cebolla"),
                new Ingrediente("Mostaza"),
                new Ingrediente("Ketchup"),
                new Ingrediente("Mayonesa"),
                new Ingrediente("Pepperoni"),
                new Ingrediente("Piña"),
                new Ingrediente("Pimenton"),
                new Ingrediente("Aceitunas Verdes"),
                new Ingrediente("Aceitunas Negras")
        };

        public MainWindow()
        {
            InitializeComponent();
            crearLista();
            ShowData();
            llenarCmbFiltrar();
        }

        public void ShowData()
        {
            foreach (Plato plato in platos)
            {
                lstVisualizar.Items.Add(plato.platoName + "\t" + " --> " + "\t" + " Precio: " + plato.platoPrice);
                lstVisualizar.Items.Add("Ingredientes:");
                foreach (Ingrediente ingrediente in plato.Ingredientes)
                {
                    lstVisualizar.Items.Add("\t" + ingrediente.ingName);
                }
                lstVisualizar.Items.Add("-----------------------------------------------------");
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            foreach (Plato plato in platos)
            {
                if (plato.platoName == txbPlato.Text)
                {
                    lstPedidos.Items.Add(plato.platoName + "\t" + " --> " + "\t" + " Precio: " + plato.platoPrice);
                    lstPedidos.Items.Add("Ingredientes:");
                    foreach (Ingrediente ingrediente in plato.Ingredientes)
                    {
                        lstPedidos.Items.Add("\t" + ingrediente.ingName);
                    }
                }
            }
        }

        public void crearLista()
        {
            //Plato 1
            List<Ingrediente> ingPlato1 = new List<Ingrediente>()
            {
                new Ingrediente("Tomate"),
                new Ingrediente("Cebolla"),
                new Ingrediente("Lechuga"),
                new Ingrediente("Tocino"),
                new Ingrediente("Queso"),
                new Ingrediente("Pepinillos"),
                new Ingrediente("Carne"),
                new Ingrediente("Mostaza"),
                new Ingrediente("Ketchup"),
                new Ingrediente("Mayonesa")
            };
            platos.Add(new Plato("Hamburguesa", 20, ingPlato1));

            //Plato 2
            List<Ingrediente> ingPlato2 = new List<Ingrediente>()
            {
                new Ingrediente("Papas"),
                new Ingrediente("Tomate"),
                new Ingrediente("Choclitos"),
                new Ingrediente("Mostaza"),
                new Ingrediente("Ketchup"),
                new Ingrediente("Mayonesa")
            };
            platos.Add(new Plato("Hot Dog", 15, ingPlato2));

            //Plato 3
            List<Ingrediente> ingPlato3 = new List<Ingrediente>()
            {
                new Ingrediente("Pepperoni"),
                new Ingrediente("Cebolla"),
                new Ingrediente("Piña"),
                new Ingrediente("Pimenton"),
                new Ingrediente("Aceitunas Verdes"),
                new Ingrediente("Aceitunas Negras")
            };
            platos.Add(new Plato("Pizza", 25, ingPlato3));
        }

        public void llenarCmbFiltrar()
        {
            foreach (Ingrediente ingrediente in ingDsiponibles)
            {
                cmbQuiero.Items.Add(ingrediente.ingName);
                cmbNoQuiero.Items.Add(ingrediente.ingName);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            platos.Clear();
            crearLista();
            lstVisualizar.Items.Clear();
            cmbNoQuiero.SelectedValue = null;
            cmbQuiero.SelectedValue = null;
            ShowData();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            lstVisualizar.Items.Clear(); 

            if (cmbQuiero.SelectedIndex != -1 && cmbNoQuiero.SelectedIndex == -1)
            {
                foreach (Plato plato in platos)
                {
                    foreach (Ingrediente ingredientes in plato.Ingredientes)
                    {
                        if (cmbQuiero.SelectedItem == ingredientes.ingName)
                        {
                            lstVisualizar.Items.Add(plato.platoName + "\t" + " --> " + "\t" + " Precio: " + plato.platoPrice);
                            foreach (Ingrediente ing in plato.Ingredientes)
                            {
                                lstVisualizar.Items.Add(ing.ingName + "\t");
                            }
                            lstVisualizar.Items.Add("-----------------------------------------------------");
                        } 
                    }
                }
            }

            if (cmbQuiero.SelectedIndex == -1 && cmbNoQuiero.SelectedIndex != -1)
            {
                noQuieroFiltro();

                foreach (Plato plato in platos)
                {
                    lstVisualizar.Items.Add(plato.platoName + "\t" + " --> " + "\t" + " Precio: " + plato.platoPrice);

                    foreach (Ingrediente ing in plato.Ingredientes)
                    {
                        lstVisualizar.Items.Add(ing.ingName + "\t");
                    }
                    lstVisualizar.Items.Add("-----------------------------------------------------");
                }
            }

            /*if (cmbQuiero.SelectedIndex == -1 && cmbNoQuiero.SelectedIndex == -1)
            {
                foreach (Plato plato in platos)
                {
                    foreach (Ingrediente ingredientes in plato.Ingredientes)
                    {
                        if (cmbQuiero.SelectedItem == ingredientes.ingName && cmbNoQuiero.SelectedItem != ingredientes.ingName)
                        {
                            lstVisualizar.Items.Add(plato.platoName + "\t" + " --> " + "\t" + " Precio: " + plato.platoPrice);
                            foreach (Ingrediente ing in plato.Ingredientes)
                            {
                                lstVisualizar.Items.Add(ing.ingName + "\t");
                            }
                            lstVisualizar.Items.Add("-----------------------------------------------------");
                        }
                    }
                }
            }*/
        }

        public void noQuieroFiltro()
        {
            int aux = 0;
            int[] arregloAux = new int[3];
            int c = 1;

            foreach (Plato plato in platos)
            {
                foreach (Ingrediente ingredientes in plato.Ingredientes)
                {
                    if (cmbNoQuiero.SelectedItem == ingredientes.ingName)
                    {
                        arregloAux[c - 1] = aux;
                        c++;
                    }
                }
                aux++;
            }

            for (int i = 0; i < c - 1; i++)
            {
                platos.RemoveAt(arregloAux[i]);
            }
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            foreach (Plato plato in platos)
            {
                if (plato.platoName == txbPlato.Text)
                {
                    if (MessageBoxResult.OK == MessageBox.Show("Su pedido es: " + plato.platoName + " - Precio: " + plato.platoPrice + "\n" + "Desea confirmar el pedido?", "Pedido", MessageBoxButton.OKCancel, MessageBoxImage.Question))
                    {
                        MessageBox.Show("PEDIDO CONFIRMADO", "Pedido", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("PEDIDO CANCELADO", "Cancelado", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }                   
                }
            }
        }

        private void btnBorrarPedido_Click(object sender, RoutedEventArgs e)
        {
            lstPedidos.Items.Clear();
        }
    }
}