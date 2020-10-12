﻿namespace Moniturl.Core
{
    public class TargetSearchParams
    {
        private const int MaxTake = 50;

        public int Skip { get; set; } = 0;

        private int _take = 3;
        public int Take
        {
            get => _take;
            set => _take = (value >= MaxTake) ? MaxTake : value;
        }

        public int? UserId { get; set; }

        public string Sort { get; set; }

        private string _search;

        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }
    }
}
