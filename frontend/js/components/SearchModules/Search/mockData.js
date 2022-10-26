export default {
  query: {
    listingId: "767df95e-a359-4eb6-90b6-5f005cfe359a",
    showDescriptions: true,
    showDates: true,
    showContentTypes: true,
    showTaxonomyLabels: true,
    loadAllPages: false,
    pageId: "26efa0b9-f177-47a0-b5d2-bffa469aa15a",
    showSummaries: true,
    perPage: 8,
  },
  model: {
    url: "/api/search",
    featuredUrl: "/api/featuredresults",
    pagination: true,
    loadMore: false,
    hideMobileSummary: false,
    showFacets: true,
    sorters: [
      {
        id: "{C19ECE9E-7443-4C0C-A6E6-5EABBDEC22CD}",
        label: "Relevance",
        value: "relevance",
        direction: null,
        isActive: true,
      },
      {
        id: "{447C031B-9283-4B83-88B2-6881671D5CED}",
        label: "Alphabetical",
        value: "alpha",
        direction: "asc",
        isActive: false,
      },
      {
        id: "{EFB3BC12-50B0-4961-8A48-9B2A16C069E7}",
        label: "Date",
        value: "date",
        direction: "desc",
        isActive: false,
      },
    ],
  },
  dictionary: {
    clearAll: "Clear Filters",
    ctaText: "See Services",
    featuredResultLabel: "Featured Result",
    filterTitle: "Filter Your Results",
    filterLabel: "",
    loadMoreLabel: "More Articles",
    newResultsMessage: "New Results",
    removeFilterLabel: "Remove filter",
    resultsInfoLabel: "Showing",
    searchBoxPlaceholder: "Search by keyword",
    searchBoxLabel: "Submit Search",
    selectedFiltersLabel: "with filters",
    sortBy: "Sort By:",
  },
};
