using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Iamopen.Availability.AMS.Proxy;
using Iamopen.Common.ServiceModels;

namespace Iamopen.Availability.AMS.TestClient
{
    public class TableControl
    {
        private static readonly ICommand ServiceCommand = new RoutedCommand();
        private static readonly InputGesture Click = new MouseGesture(MouseAction.LeftClick);
        private static int TablesCount = 0;

        private const int DefaultWidth = 30;
        private const int DefaultHeight = 20;

        private readonly Canvas table;
        private bool isReserved = false;
        private int tableID;

        public TableControl(Panel parent, double x, double y)
        {
            table = new Canvas { Width = DefaultWidth, Height = DefaultHeight, Background = Brushes.GreenYellow };
            Canvas.SetLeft(table, x);
            Canvas.SetTop(table, y);

            TablesCount++;
            tableID = TablesCount;

            var tb = new TextBlock {Text = tableID.ToString()};
            table.Children.Add(tb);

            var cb = new CommandBinding(ServiceCommand, ServiceCommandExecute, ServiceCommandCanExecute);
            table.CommandBindings.Add(cb);
            table.InputBindings.Add(new InputBinding(ServiceCommand, Click));

            parent.Children.Add(table);
        }

        private void ServiceCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ServiceCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            isReserved = !isReserved;
            TableStatus tableStatus;
            if (isReserved)
            {
                this.table.Background = Brushes.Tomato;
                tableStatus = TableStatus.Busy;
            }
            else
            {
                this.table.Background = Brushes.GreenYellow;
                tableStatus  = TableStatus.Free;
            }
            var result = SafeAMS.ChangeTableStatus(tableID, tableStatus);
            if (result.ExecutionResult.ResultCode != ResultCode.OK)
            {
                MessageBox.Show("Error: " + result.ExecutionResult.EndUserErrorMessage);
            }

        }
    }
}
