﻿using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class NoteInformationsList:NoteInformations,IBaseActionEntity
    {
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}