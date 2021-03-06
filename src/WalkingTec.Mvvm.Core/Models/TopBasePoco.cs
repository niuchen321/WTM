﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WalkingTec.Mvvm.Core
{
    /// <summary>
    /// TopBasePoco
    /// </summary>
    public class TopBasePoco
    {
        private Guid _id;

        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public Guid ID
        {
            get
            {
                if (_id == Guid.Empty)
                {
                    _id = Guid.NewGuid();
                }
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// 是否选中
        /// 标识当前行数据是否被选中
        /// </summary>
        [NotMapped]
        //[JsonConverter(typeof(InternalBoolConverter))]
        //[JsonProperty("LAY_CHECKED")]
        [JsonIgnore]
        public bool Checked { get; set; }

        /// <summary>
        /// BatchError
        /// </summary>
        [NotMapped]
        [JsonIgnore]
        public string BatchError { get; set; }

        /// <summary>
        /// ExcelIndex
        /// </summary>
        [NotMapped]
        [JsonIgnore]
        public long ExcelIndex { get; set; }

    }
}
