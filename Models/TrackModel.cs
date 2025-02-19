﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CropManagementAPI.Models
{
	public class TrackModel
	{
		[Key]
		public int track_id { get; set; }

		[Required]
		public string CropId { get; set; }

		[Required]
		[ForeignKey("User")]
		public int user_id { get; set; }

		public DateTime? sown { get; set; }

		public DateTime? watered { get; set; }

		public DateTime[]? fed { get; set; }

        public DateTime[]? harvested { get; set; }





	}
}
