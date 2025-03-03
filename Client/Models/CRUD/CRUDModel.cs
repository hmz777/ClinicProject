﻿namespace ClinicProject.Client.Models.CRUD
{
    public class CRUDModel
    {
        public string SearchString { get; set; }
        public string SortLabel { get; set; }
        public SortDirection SortDirection { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public Dictionary<string, Tuple<object, ODataFilterOp, ODataOperand>> EqFilters { get; set; }
        public List<string> SelectedProperties { get; set; }
        public List<string> ExpandedProperties { get; set; }
        public bool HasFilter()
        {
            return EqFilters != null && EqFilters.Count > 0;
        }

        public bool HasSelect()
        {
            return SelectedProperties != null && SelectedProperties.Count > 0;
        }

        public bool HasSearch()
        {
            return !string.IsNullOrWhiteSpace(SearchString);
        }

        public bool HasExpand()
        {
            return ExpandedProperties != null && ExpandedProperties.Count > 0;
        }
    }
}