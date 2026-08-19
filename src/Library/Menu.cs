//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;
using System.Globalization;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
public class Menu
    {
        private ArrayList dishes = new ArrayList();

        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            this.dishes.Remove(dish);
        }

        public Dish GetDishByName(string name)
        {
            foreach (Dish dish in this.dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }
            return null;
        }
    }
}


