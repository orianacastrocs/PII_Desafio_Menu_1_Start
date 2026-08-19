//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
   
    /// Representaremos una querida mesa de comensales.
    
    public class Table
    {
        // 1
        public int Number { get; private set; }
        public bool IsOccupied { get; private set; }

        private ArrayList order = new ArrayList();

        // 2
        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }

        // 3. 
        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear(); 
        }

        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}
