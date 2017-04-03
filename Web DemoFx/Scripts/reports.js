function buildReportTree()
{
    dm = new dTree('dm');

    // Categories
    dm.add(0, -1, '');
    dm.add(1, 0, 'Basic Reports', null, null, null, null, null, true);
    dm.add(2, 0, 'Reports with Columns');
    dm.add(3, 0, 'Master-Detail Reports');
    dm.add(4, 0, 'Reports with Groups');
    dm.add(5, 0, 'Hierarchical Reports');
    //dm.add(6, 0, 'Interactive Reports');
    dm.add(7, 0, 'Parameters');
    dm.add(8, 0, 'Charts');
    dm.add(9, 0, 'Cross-Tab Reports');
    dm.add(10, 0, 'Reports with EmptyBand');
    dm.add(11, 0, 'Containers');
    dm.add(12, 0, 'SubReports');

    // Basic Reports
    dm.add(101, 1, 'Simple List', '/View/Reports/SimpleList');
    dm.add(102, 1, 'Two Simple Lists', '/View/Reports/TwoSimpleLists');
    dm.add(103, 1, 'Highlight Condition', '/View/Reports/HighlightCondition');
    dm.add(104, 1, 'Shapes', '/View/Reports/Shapes');
    dm.add(105, 1, 'Images', '/View/Reports/Images');
    dm.add(106, 1, 'RichText', '/View/Reports/RichText');
    dm.add(107, 1, 'Watermark', '/View/Reports/Watermark');
    dm.add(108, 1, 'Bar-Codes', '/View/Reports/BarCodes');
    dm.add(109, 1, 'Invoice', '/View/Reports/Invoice');
    dm.add(110, 1, 'Indicators', '/View/Reports/Indicators');
    
    // Reports with Columns
    dm.add(201, 2, 'Multi-Column List', '/View/Reports/MultiColumnList');
    dm.add(202, 2, 'Multi-Column Bands, Across-Down', '/View/Reports/MultiColumnBandsAcrossThenDown');
    dm.add(203, 2, 'Multi-Column Bands, Down-Across', '/View/Reports/MultiColumnBandsDownThenAcross');
    dm.add(204, 2, 'Labels', '/View/Reports/Labels');
    
    // Master-Detail Reports
	dm.add(301, 3, 'Master-Detail', '/View/Reports/MasterDetail');
	dm.add(302, 3, 'Master-Detail-Subdetail', '/View/Reports/MasterDetailSubdetail');
	dm.add(303, 3, 'Master-Detail with Columns', '/View/Reports/MasterDetailWithColumns');
    dm.add(304, 3, 'Two Masters on One Detail', '/View/Reports/TwoMastersOnOneDetail');
    dm.add(305, 3, 'Master-Detail with zero Height', '/View/Reports/MasterDetailWithZeroHeight');
    dm.add(306, 3, 'Master-Detail on DataBand', '/View/Reports/MasterDetailOnDataBand');
    
    // Reports with Groups
    dm.add(401, 4, 'Simple Group', '/View/Reports/SimpleGroup');
    dm.add(402, 4, 'Nested Groups', '/View/Reports/NestedGroups');
    dm.add(403, 4, 'Top Sales', '/View/Reports/GroupsTopSales');
    dm.add(404, 4, 'Master-Detail with Groups', '/View/Reports/MasterDetailWithGroups');
    dm.add(405, 4, 'Multi-Column Group', '/View/Reports/MultiColumnGroup');
    dm.add(406, 4, 'Groups with Ranges', '/View/Reports/GroupsWithRanges');
    dm.add(407, 4, 'Simple Group with Columns', '/View/Reports/SimpleGroupWithColumns');
    dm.add(408, 4, 'All Group Footers at End', '/View/Reports/AllGroupFootersAtEnd');
    dm.add(409, 4, 'Invoice with Groups', '/View/Reports/InvoiceWithGroups');
    dm.add(410, 4, 'Sales Invoice', '/View/Reports/SalesInvoice');
    
    // Hierarchical Reports
    dm.add(501, 5, 'Tree', '/View/Reports/Tree');
    dm.add(502, 5, 'Tree with Headers and Footers', '/View/Reports/TreeWithHeadersFooters');
    dm.add(503, 5, 'Tree with Totals', '/View/Reports/TreeWithTotals');
    dm.add(504, 5, 'Tree with Totals, All Levels', '/View/Reports/TreeWithTotalsAllLevels');
    dm.add(505, 5, 'Tree with Locked Components', '/View/Reports/TreeWithLockedComponents');
    
    // Interactive Reports
    //dm.add(601, 6, 'Interactive Sorting', '/View/Reports/DrillDownSorting');
    
    // Parameters
    dm.add(701, 7, 'Detailed Categories', '/View/Reports/ParametersDetailedCategories');
    dm.add(702, 7, 'Detailed Orders', '/View/Reports/ParametersDetailedOrders');
    dm.add(703, 7, 'Highlight Condition', '/View/Reports/ParametersHighlightCondition');
    dm.add(704, 7, 'Selecting Country', '/View/Reports/ParametersSelectingCountry');
    dm.add(705, 7, 'Invoice', '/View/Reports/ParametersInvoice');
    
    // Charts
    dm.add(801, 8, 'Population', '/View/Reports/ChartPopulation');
    dm.add(802, 8, 'GDP Growth 2005-2010', '/View/Reports/ChartGDPGrowth20052010');
    dm.add(803, 8, 'Global Growth 2006 and 2008', '/View/Reports/ChartGlobalGrowth20062008');
    dm.add(804, 8, 'Global Growth 2008', '/View/Reports/ChartGlobalGrowth2008');
    dm.add(805, 8, 'Migration by Decade in USA', '/View/Reports/ChartMigrationByDecadeInUSA');
    dm.add(806, 8, 'Foreign official reserves in Euro', '/View/Reports/ChartForeignOfficialReservesInEuro');
    dm.add(807, 8, 'Oil Extraction by Countries', '/View/Reports/ChartOilExtractionByCountries');
    dm.add(808, 8, 'Produced Cars', '/View/Reports/ChartProducedCars');
    dm.add(809, 8, 'Chart Styles', '/View/Reports/ChartStyles');
    dm.add(810, 8, 'Chart on DataBand', '/View/Reports/ChartOnDataBand');
    
    // Cross-Tabs Reports
    dm.add(901, 9, 'Standard Cross-Tab', '/View/Reports/StandardCrossTab');
    dm.add(902, 9, 'Cross-Tab without Columns', '/View/Reports/CrossTabWithoutColumns');
    dm.add(903, 9, 'Cross-Tab without Rows', '/View/Reports/CrossTabWithoutRows');
    dm.add(904, 9, 'Cross-Tab with Highlight Condition', '/View/Reports/CrossTabWithHighlightCondition');
    dm.add(905, 9, 'Cross-Tab with Two Summaries', '/View/Reports/CrossTabWithTwoSummaries');
    dm.add(906, 9, 'Two Cross-Tabs', '/View/Reports/TwoCrossTabs');
    dm.add(907, 9, 'Wrapped Cross-Tabs', '/View/Reports/WrappedCrossTab');
    dm.add(908, 9, 'Large Cross-Tab', '/View/Reports/LargeCrossTab');
    dm.add(909, 9, 'Cross-Tab on DataBand', '/View/Reports/CrossTabOnDataBand');
    
    // Reports with EmptyBand
    dm.add(1001, 10, 'Simple List with Empty Lines', '/View/Reports/SimpleListWithEmptyLines');
    dm.add(1002, 10, 'Master-Detail with Empty Lines', '/View/Reports/MasterDetailWithEmptyLines');
    dm.add(1003, 10, 'Invoice with Empty Band', '/View/Reports/InvoiceWithEmptyBand');
    
    // Containers
    dm.add(1101, 11, 'Side by Side List', '/View/Reports/SideBySideListWithContainers');
    dm.add(1102, 11, 'Side by Side Group', '/View/Reports/SideBySideGroupWithContainers');
    dm.add(1103, 11, 'Multi-Column List', '/View/Reports/MultiColumnListContainers');
    dm.add(1104, 11, 'Multi-Containers', '/View/Reports/MultiContainers');
    dm.add(1105, 11, 'Master-Detail Cards', '/View/Reports/MasterDetailCards');
    
    // SubReports
    dm.add(1201, 12, 'Side by Side List', '/View/Reports/SideBySideListWithSubReports');
    dm.add(1202, 12, 'Side by Side List on DataBand', '/View/Reports/SideBySideListWithSubReportsOnDataBand');
    dm.add(1203, 12, 'Side by Side Group', '/View/Reports/SideBySideGroupWithSubReports');
    dm.add(1204, 12, 'Master-Detail', '/View/Reports/MasterDetailWithSubReports');
    
    document.write(dm);
}