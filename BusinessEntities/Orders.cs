﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Orders : IOrders
    {
        private int orderID;
        private string food;
        private double foodprice;
        private string drink;
        private double drinkprice;
        private string timestamp;


        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }
        public string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }

        public double FoodPrice
        {
            get
            {
                return foodprice;
            }
            set
            {
                foodprice = value;
            }
        }
        public string Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
            }
        }
        public double DrinkPrice
        {
            get
            {
                return drinkprice;
            }
            set
            {
                drinkprice = value;
            }
        }

        public string Timestamp
        {
            get
            {
                return Timestamp;
            }
            set
            {
                Timestamp = value;
            }
        }
        public Orders()
        {
            throw new System.NotImplementedException();
        }
        public Orders(int OrderID, string Food, double FoodPrice, string Drink, double Drinkprice, string Timestamp)
        {
            this.orderID = OrderID;
            this.food = Food;
            this.foodprice = FoodPrice;
            this.drink = Drink;
            this.drinkprice = Drinkprice;
            this.timestamp = Timestamp;



        }

    }
}