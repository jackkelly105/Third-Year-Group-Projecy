﻿using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(BusinessEntities.IUser theUser);
        void closeConnection();
        System.Collections.ArrayList GetAllUsers();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
        bool deleteUserFromDB(BusinessEntities.IUser user);

        bool deleteReservationFromDB(BusinessEntities.IReservation reservation);

        List<IRoom> getAllRooms();

        List<IGuest> getAllGuests();

        List<IReservation> getAllReservations();

        List<IRoom> getRoomForDates(string CheckIn, string CheckOut);

        List<IRoomCleaningRecord> getAllRoomCleaningRecords();

        void addNewGuestToDB(BusinessEntities.IGuest theGuest);
        void addNewReservationToDB(BusinessEntities.IReservation theReservation);

        void addNewRoomCleaningRecordToDB(BusinessEntities.IRoomCleaningRecord theRecord);
        bool updateReservationFromDB(BusinessEntities.IReservation reservation);
        bool updateGuestFromDB(BusinessEntities.IGuest guest);

<<<<<<< HEAD
        List<IBarItems> getAllbarItems();
=======
        bool updateRoomPriceInDB(BusinessEntities.IRoom room);

        bool checkGusetInDB(BusinessEntities.IReservation reservation);

>>>>>>> 9758fac5420bb43eaa1da570c10a0fd1450962bd

    }
}
