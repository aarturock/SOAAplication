﻿using Core.Common.Contracts;
using Core.Common.Core;
using System.Runtime.Serialization;
using System;

namespace CarRental.Business.Entities
{
    [DataContract]
    public class Car:EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Color { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public decimal RentalPrice { get; set; }

        [DataMember]
        public bool CurrentlyRented { get; set; }

        public int Entity
        {
            get { return CarId; }
            set { CarId = value; }
        }
    }
}
