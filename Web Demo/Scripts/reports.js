function buildReportTree()
{
    dm = new dTree('dm');

    // Categories
    dm.add(0, -1, '');
    dm.add(1, 0, 'Basic Reports', null, null, null, null, null, true);
    dm.add(2, 0, 'Invoices');
    dm.add(3, 0, 'Reports with Columns');
    dm.add(4, 0, 'Master-Detail Reports');
    dm.add(5, 0, 'Reports with Groups');
    dm.add(6, 0, 'Hierarchical Reports');
    dm.add(7, 0, 'Parameters in Reports');
    dm.add(8, 0, 'Interactive Reports');
    dm.add(9, 0, 'Reports with Table');
    dm.add(10, 0, 'Real-life Charts');
    dm.add(11, 0, 'Reports with Charts');
    dm.add(12, 0, 'Reports with Gauges');
    dm.add(13, 0, 'Cross-Tab in Reports');
    dm.add(14, 0, 'Empty Rows in Reports');
    dm.add(15, 0, 'Using Panels in Reports');
    dm.add(16, 0, 'Sub-Reports');
    dm.add(17, 0, 'Table of Contents');
    dm.add(18, 0, 'Business Reports');

    // Basic Reports
    dm.add(101, 1, 'Simple List', '/View/Reports/SimpleList');
    dm.add(102, 1, 'Two Simple Lists', '/View/Reports/TwoSimpleLists');
    dm.add(103, 1, 'Highlight Condition', '/View/Reports/HighlightCondition');
    dm.add(104, 1, 'Shapes', '/View/Reports/Shapes');
    dm.add(105, 1, 'Images', '/View/Reports/Images');
    dm.add(106, 1, 'RichText', '/View/Reports/RichText');
    dm.add(107, 1, 'Watermark', '/View/Reports/Watermark');
    dm.add(108, 1, 'Bar-Codes', '/View/Reports/BarCodes');
    dm.add(109, 1, 'Indicators', '/View/Reports/Indicators');
    dm.add(110, 1, 'Html-Tags', '/View/Reports/HtmlTags');

    // Invoices
    dm.add(201, 2, 'Business Invoice', '/View/Reports/BusinessInvoice');
    dm.add(202, 2, 'Billing Statement', '/View/Reports/BillingStatement');
    dm.add(203, 2, 'Insurance-Light', '/View/Reports/Insurance-Light');
    dm.add(204, 2, 'Invoice', '/View/Reports/Invoice');
    dm.add(205, 2, 'Invoice with Groups', '/View/Reports/InvoiceWithGroups');
    dm.add(206, 2, 'Order', '/View/Reports/Order');
    dm.add(207, 2, 'Quotation', '/View/Reports/Quotation');
    dm.add(208, 2, 'Recurring Invoice', '/View/Reports/RecurringInvoice');
    dm.add(209, 2, 'Sales Invoice', '/View/Reports/SalesInvoice');
    dm.add(210, 2, 'Service Invoice', '/View/Reports/ServiceInvoice');
    dm.add(211, 2, 'Switzerland Invoice', '/View/Reports/SwitzerlandInvoice');
    
    // Reports with Columns
    dm.add(301, 3, 'Multi-Column List', '/View/Reports/MultiColumnList');
    dm.add(302, 3, 'Multi-Column Bands, Across-Down', '/View/Reports/MultiColumnBandsAcrossThenDown');
    dm.add(303, 3, 'Multi-Column Bands, Down-Across', '/View/Reports/MultiColumnBandsDownThenAcross');
    dm.add(304, 3, 'Labels', '/View/Reports/Labels');
    
    // Master-Detail Reports
	dm.add(401, 4, 'Master-Detail', '/View/Reports/MasterDetail');
	dm.add(402, 4, 'Master-Detail-Subdetail', '/View/Reports/MasterDetailSubdetail');
	dm.add(403, 4, 'Master-Detail with Columns', '/View/Reports/MasterDetailWithColumns');
    dm.add(404, 4, 'Two Masters on One Detail', '/View/Reports/TwoMastersOnOneDetail');
    dm.add(405, 4, 'Master-Detail with Zero Height', '/View/Reports/MasterDetailWithZeroHeight');
    dm.add(406, 4, 'Master-Detail on Data Band', '/View/Reports/MasterDetailOnDataBand');
    
    // Reports with Groups
    dm.add(501, 5, 'Simple Group', '/View/Reports/SimpleGroup');
    dm.add(502, 5, 'Nested Groups', '/View/Reports/NestedGroups');
    dm.add(503, 5, 'Top Sales', '/View/Reports/TopSales');
    dm.add(504, 5, 'Master-Detail with Groups', '/View/Reports/MasterDetailWithGroups');
    dm.add(505, 5, 'Multi-Column Group', '/View/Reports/MultiColumnGroup');
    dm.add(506, 5, 'Groups with Ranges', '/View/Reports/GroupsWithRanges');
    dm.add(507, 5, 'Simple Group with Columns', '/View/Reports/SimpleGroupWithColumns');
    dm.add(508, 5, 'All Group Footers at End', '/View/Reports/AllGroupFootersAtEnd');
    dm.add(509, 5, 'Sales Invoice', '/View/Reports/SalesInvoice');
    
    // Hierarchical Reports
    dm.add(601, 6, 'Tree', '/View/Reports/Tree');
    dm.add(602, 6, 'Tree with Headers and Footers', '/View/Reports/TreeWithHeadersAndFooters');
    dm.add(603, 6, 'Tree with Totals', '/View/Reports/TreeWithTotals');
    dm.add(604, 6, 'Tree with Totals, All Levels', '/View/Reports/TreeWithTotalsAllLevels');
    dm.add(605, 6, 'Tree with Locked Components', '/View/Reports/TreeWithLockedComponents');

    // Parameters
    dm.add(701, 7, 'Detailed Categories', '/View/Reports/ParametersDetailedCategories');
    dm.add(702, 7, 'Detailed Orders', '/View/Reports/ParametersDetailedOrders');
    dm.add(703, 7, 'Highlight Condition', '/View/Reports/ParametersHighlightCondition');
    dm.add(704, 7, 'Selecting Country', '/View/Reports/ParametersSelectingCountry');
    dm.add(705, 7, 'Invoice', '/View/Reports/ParametersInvoice');
    dm.add(706, 7, 'Dependent Parameter', '/View/Reports/ParametersDependentParameter');
    dm.add(707, 7, 'Two Dependent Parameters', '/View/Reports/ParametersTwoDependentParameters');

    // Interactive Reports
    dm.add(801, 8, 'List of Products', '/View/Reports/ListOfProducts');
    dm.add(802, 8, 'Cross-Tab with Detailing', '/View/Reports/CrossTabWithDetailing');
    dm.add(803, 8, 'Interactive Sorting', '/View/Reports/Sorting');
    dm.add(804, 8, 'Table with Sorting', '/View/Reports/TableWithSorting');
    dm.add(805, 8, 'Group with Collapsing', '/View/Reports/GroupWithCollapsing');
    dm.add(806, 8, 'Group with Collapsing without Footer', '/View/Reports/GroupWithCollapsingWithoutFooter');
    dm.add(807, 8, 'Tree with Collapsing', '/View/Reports/TreeWithCollapsing');
    dm.add(808, 8, 'Master-Detail with Collapsing', '/View/Reports/MasterDetailWithCollapsing');
    dm.add(809, 8, 'Editable', '/View/Reports/EditableReport');
    dm.add(810, 8, 'Bookmarks and Hyperlinks', '/View/Reports/BookmarksAndHyperlinks');
    dm.add(811, 8, 'Interactive Charts', '/View/Reports/InteractiveCharts');

    // Reports with Table
    dm.add(901, 9, 'Simple Table', '/View/Reports/TableSimpleTable');
    dm.add(902, 9, 'Master-Detail-Subdetail', '/View/Reports/TableMasterDetailSubdetail');
    dm.add(903, 9, 'Simple Group', '/View/Reports/TableSimpleGroup');
    dm.add(904, 9, 'Invoice with Groups', '/View/Reports/TableInvoiceWithGroups');
    dm.add(905, 9, 'Table with Images', '/View/Reports/TableImages');
    dm.add(906, 9, 'Dependent Parameter', '/View/Reports/ParametersDependentParameter');
    dm.add(907, 9, 'Fixed Width of Columns', '/View/Reports/TableFixedWidthOfColumns');
    
    // Real-life Charts
    dm.add(1001, 10, 'Global Growth 2015-2017', '/View/Reports/GlobalGrowth2015-2017');
    dm.add(1002, 10, 'Population', '/View/Reports/Population');
    dm.add(1004, 10, 'Chart with Negatives', '/View/Reports/GDPGrowth2007-2017');
    dm.add(1005, 10, 'Global Growth', '/View/Reports/GlobalGrowth2017');
    dm.add(1006, 10, 'Tasks by Date', '/View/Reports/TasksByDate');
    dm.add(1007, 10, 'Foreign Official Reserves', '/View/Reports/ForeignOfficialReserves');
    dm.add(1008, 10, 'Migration by Decade in USA', '/View/Reports/MigrationByDecadeInUSA');
    dm.add(1009, 10, 'Natural Gas Production', '/View/Reports/NaturalGasProduction');
    dm.add(1010, 10, 'Top Auto Sales in USA-16', '/View/Reports/TopAutoSalesInUSA16');
    dm.add(1011, 10, 'Top sellers of cars in October 2016', '/View/Reports/TopSellersOfCars');

    // Charts
    dm.add(1101, 11, 'Clustered Column', '/View/Reports/ClusteredColumn');
    dm.add(1102, 11, 'Line', '/View/Reports/Line');
    dm.add(1103, 11, 'Pie', '/View/Reports/Pie');
    dm.add(1104, 11, 'Doughnut', '/View/Reports/Doughnut');
    dm.add(1105, 11, 'Clustered Bar', '/View/Reports/ClusteredBar');
    dm.add(1106, 11, 'Gantt', '/View/Reports/Gantt');
    dm.add(1107, 11, 'Area', '/View/Reports/Area');
    dm.add(1108, 11, 'Range', '/View/Reports/Range');
    dm.add(1109, 11, 'Scatter', '/View/Reports/Scatter');
    dm.add(1110, 11, 'Bubble', '/View/Reports/Bubble');
    dm.add(1111, 11, 'Funnel', '/View/Reports/Funnel');
    dm.add(1112, 11, 'Financial', '/View/Reports/Financial');
    dm.add(1113, 11, 'Radar', '/View/Reports/Radar');
    dm.add(1114, 11, 'Treemap', '/View/Reports/Treemap');
    dm.add(1115, 11, 'Sunburst', '/View/Reports/Sunburst');
    dm.add(1116, 11, 'Histogram', '/View/Reports/Histogram');
    dm.add(1117, 11, 'Pareto', '/View/Reports/Pareto');
    dm.add(1118, 11, 'Waterfall', '/View/Reports/Waterfall');
    dm.add(1119, 11, 'Pictorial', '/View/Reports/Pictorial');

    // Reports with Gauges
    dm.add(1201, 12, 'Linear', '/View/Reports/GaugeLinear');
    dm.add(1202, 12, 'Radial', '/View/Reports/GaugeRadial');
    
    // Cross-Tabs Reports
    dm.add(1301, 13, 'Standard Cross-Tab', '/View/Reports/StandardCrossTab');
    dm.add(1302, 13, 'Cross-Tab without Columns', '/View/Reports/CrossTabWithoutColumns');
    dm.add(1303, 13, 'Cross-Tab without Rows', '/View/Reports/CrossTabWithoutRows');
    dm.add(1304, 13, 'Cross-Tab with Highlight Condition 1', '/View/Reports/CrossTabWithHighlightCondition1');
    dm.add(1305, 13, 'Cross-Tab with Highlight Condition 2', '/View/Reports/CrossTabWithHighlightCondition2');
    dm.add(1306, 13, 'Cross-Tab with Two Summaries', '/View/Reports/CrossTabWithTwoSummaries');
    dm.add(1307, 13, 'Two Cross-Tabs', '/View/Reports/TwoCrossTabs');
    dm.add(1308, 13, 'Wrapped Cross-Tabs', '/View/Reports/WrappedCrossTabs');
    dm.add(1309, 13, 'Large Cross-Tab', '/View/Reports/LargeCrossTab');
    dm.add(1310, 13, 'Cross-Tab on DataBand', '/View/Reports/CrossTabOnDataBand');
    dm.add(1311, 13, 'Cross-Tab and Cross-Bands', '/View/Reports/CrossTabAndCrossBands');
    dm.add(1312, 13, 'Cross-Tab on Page', '/View/Reports/CrossTabOnPage');
    dm.add(1313, 13, 'Cross-Tab with Images', '/View/Reports/CrossTabWithImages');
    
    // Reports with EmptyBand
    dm.add(1401, 14, 'Simple List', '/View/Reports/EmptyRowsSimpleList');
    dm.add(1402, 14, 'Master-Detail', '/View/Reports/EmptyRowsMasterDetail');
    dm.add(1403, 14, 'Invoice', '/View/Reports/EmptyRowsInvoice');
    
    // Panels
    dm.add(1501, 15, 'Side-by-Side List', '/View/Reports/PanelsSideBySideLists');
    dm.add(1502, 15, 'Side-by-Side Group', '/View/Reports/PanelsSideBySideGroups');
    dm.add(1503, 15, 'Multi-Column List', '/View/Reports/PanelsMultiColumnList');
    dm.add(1504, 15, 'Multi-Panels', '/View/Reports/PanelsMultiPanels');
    dm.add(1505, 15, 'Master-Detail Cards', '/View/Reports/PanelsMasterDetailCards');
    
    // Sub-Reports
    dm.add(1601, 16, 'Side-by-Side List', '/View/Reports/SubReportsSideBySideLists');
    dm.add(1602, 16, 'Side-by-Side List on Data Band', '/View/Reports/SubReportsSideBySideListsOnDataBand');
    dm.add(1603, 16, 'Side-by-Side Group', '/View/Reports/SubReportsSideBySideGroups');
    dm.add(1604, 16, 'Master-Detail', '/View/Reports/SubReportsMasterDetail');
    
    // Table of Contents
    dm.add(1701, 17, 'Master-Detail Report with TOC', '/View/Reports/MasterDetailReportWithTOC');
    dm.add(1702, 17, 'Multi-Column List with TOC', '/View/Reports/MultiColumnListWithTOC');
    dm.add(1703, 17, 'Panels with TOC', '/View/Reports/PanelsWithTOC');
    dm.add(1704, 17, 'Simple List with TOC', '/View/Reports/SimpleListWithTOC');
    dm.add(1705, 17, 'Sub-Reports with TOC', '/View/Reports/SubReportsWithTOC');
    dm.add(1706, 17, 'Table with TOC', '/View/Reports/TableWithTOC');
    dm.add(1707, 17, 'Two Simple Lists with TOC', '/View/Reports/TwoSimpleListsWithTOC');

    // Business Reports
    dm.add(1801, 18, 'Alibaba Revenue Stats', '/View/Reports/AlibabaRevenueStats');
    dm.add(1802, 18, 'BRIC GDP Stats', '/View/Reports/BRICGDPStats');
    dm.add(1803, 18, 'China Construction Bank', '/View/Reports/ChinaConstructionBank');
    dm.add(1804, 18, 'Expensive Buildings of China', '/View/Reports/ChinasExpensiveBuildings');
    dm.add(1805, 18, 'Manufacture in China', '/View/Reports/ManufactureInChina');
    dm.add(1806, 18, 'Population in China', '/View/Reports/PopulationInChina');
    dm.add(1807, 18, 'Statistics and Forecast of China GDP', '/View/Reports/StatisticsAndForecastOfChinaGDP');
    dm.add(1808, 18, 'Taiwan Construction Service', '/View/Reports/TaiwanConstructionService');
    dm.add(1809, 18, 'Top Countries by GDP in 2019', '/View/Reports/TopCountriesByGDPIn2019');
    dm.add(1811, 18, 'Autos Units Sales In USA', '/View/Reports/AutosAndLightTrucksUnitsSalesInUSA');
    dm.add(1812, 18, 'Employee Cards', '/View/Reports/EmployeeCards');
    dm.add(1813, 18, 'Payroll', '/View/Reports/Payroll');
    dm.add(1814, 18, 'Vehicle Sales Worldwide', '/View/Reports/VehicleSalesWorldwide');
    dm.add(1815, 18, 'Inventory Summary', '/View/Reports/InventorySummary');
    dm.add(1816, 18, 'Insurance with Selecting Country', '/View/Reports/InsuranceWithSelectingCountry');
    
    document.write(dm);
}