﻿using GminaApi.Entity;


    public class UserApplicationValueEntity : IEntity
    {
        public int ID { get; set; }
        public string ParameterName { get; set; }
        public string Value { get; set; }
        public int UserApplicationId { get; set; }
    }

