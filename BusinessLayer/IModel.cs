﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public interface IModel
    {

        bool addNewUser(string FirstName, string Surname, string Username, string Password, string userType);

        bool addNewGuest(string FirstName, string Surname, string ContactNumber, string Address, string Email, bool SendMarketingInfo);

        bool addNewReservation(DateTime CheckInDate, DateTime CheckOutDate, int Adults, int Children, double ReservationPrice, bool PayedDeposit, bool PayedInFull, int GuestID, int RoomNumber,bool CheckIn);

        bool addNewRoomCleaningRecord(int RoomNumber, DateTime CleanedAt, string Note);

        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        bool login(string username, string password);

        bool deleteUser(IUser user);

        bool deleteWaste(IWaste waste);

        bool deleteReservation(IReservation reservation);

        bool updateReservation(IReservation reservation);
        bool updateGuest(IGuest guest);

        void tearDown();
        System.Collections.ArrayList UserList { get; }
        bool PasswordCheck(string password);

        List<IRoom> RoomsList { get; set; }
        void GetAllRooms();

        List<IGuest> GuestsList { get; set; }
        void GetAllGuests();

        List<ICleaner> CleanerList { get; set; }
        void GetAllCleaner();

        List<IRoomCleaningRecord> RoomCleaningRecordsList { get; set; }

        void GetAllRoomCleaningRecords();

        List<IReservation> ReservationsList { get; set; }

        void GetAllReservations();
        List<IRoom> RoomsOnGivenDates { get; set; }
        int SelectedGuestID { get; set; }

        void getSelectedGuest(int guestid);
        void GetRoomsForDates(string CheckIn, string CheckOut);

        List<IBarItems> BarItemsList { get; set; }
        void GetAllBarItems();

        bool UpdateRoomPrice(IRoom room);

        bool CheckGuestIn(IReservation reservation);

        bool CheckGuestOut(IReservation reservation);

        List<IOrders> OrdersList { get; set; }
        void GetAllOrders();

      
        List<IIngredients> IngredientsList { get; set; }
        void GetAllIngredients();

        List<IMeals> MealsList { get; set; }
        void GetAllMeals();

        List<IWaste> WasteList { get; set; }
        void GetAllWaste();

        bool wasteToDB(IWaste waste);


        bool ChangeOrderStatus (IOrders status);


       
        bool UpdateOrderComplete(IOrders completed);

        List<IStockItem> StockItemsList { get; set; }
        void GetAllStockItems();

        List<IStockOrder> StockOrdersList { get; set; }
        void GetAllStockOrders();

        List<IOrderItem> OrderItemsList { get; set; }
        void GetAllOrderItems();

        List<IMonthlyReport> MonthlyReportsList { get; set; }
        void GetAllMonthlyReports();
        Boolean createMonthlyReport(DateTime Date, int Reservations, decimal ReservationIncome, int Sales, decimal SalesIncome, int StockOrders, decimal StockExpenses);
        Boolean createStockOrder(DateTime Date, decimal Total, String Department, int CreatedBy);
        Boolean createOrderItem(int OrderID, int ItemID, int Quantity);
        bool UpdateCurrrentStockItem(IStockItem stockItem);
        bool changePassword(IUser user);
        bool editUser(IUser user);


        List<IBistroOrders> BistroOrdersList { get; set; }
        List<IDrinks> DrinksList { get; set; }
        List<IOrder_has_Drinks> OrderDrinksList { get; set; }
        List<IOrder_has_Meals> OrderMealsList { get; set; }
        void GetAllBistroOrders();
        void GetAllDrinks();
        void GetAllOrderDrinks();
        void GetAllOrderMeals();
        bool editBistroOrder(IBistroOrders aBistroOrder);
        bool editOrderDrink(IOrder_has_Drinks anOrderDrink);
        bool editOrderMeal(IOrder_has_Meals anOrderMeal);
        bool deleteBistroOrder(IBistroOrders aBistroOrder);
        bool deleteOrderDrink(IOrder_has_Drinks anOrderDrink);
        bool deleteOrderMeal(IOrder_has_Meals anOrderMeal);
        Boolean createBistroOrder(DateTime OrderDate, decimal OrderTotal, int OrderMadeBy, string OrderNote, Boolean OrderCompleted);
        Boolean createOrderDrink(int OrderID, int DrinkID, int Quantity,  string Status);
        Boolean createOrderMeal(int OrderID, int DishID, int Quantity, string Status);
        Boolean createDrink(string DrinkName, decimal DrinkPrice);
        Boolean addPrepMeal(int DishID, string DishName, double Price, int Quantity);
        Boolean addWaste(int DishID, string DishName, int NumWasted, double LossFromWaste, DateTime Date);
        //Boolean wasteToDB(int DishID, string DishName, int NumWasted, double LossFromWaste, DateTime Date);
        Boolean addNewPayment(int PaymentID, Boolean CashPayment, Boolean CardPayment, string NameOnCard, decimal Amount);

    }
}
