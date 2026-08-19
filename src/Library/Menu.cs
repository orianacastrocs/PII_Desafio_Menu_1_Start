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
<<<<<<< HEAD
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
        public Dish GetDishByName(Dish dish)
        {
            foreach (Dish dish in dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }
            return null;
        }
=======


>>>>>>> b30e8b4b54d0524b03b0f50b149db10f75e11722
    }
}


