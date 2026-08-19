//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        // 1. Responsabilidades de conocer (Faltaban)
        public int Number { get; private set; }
        public bool IsOccupied { get; private set; }

        private ArrayList order = new ArrayList();

        // 2. Constructor: Permite inicializar las propiedades en una sola operación (Faltaba)
        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }

        // 3. Responsabilidades de hacer (Faltaban)
        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear(); // Vacía la lista usando Clear() como dice el tip
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
