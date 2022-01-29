var reportButtonsId = [];

function createReportsButtons() {
    var reportsContainer = document.getElementById("stiReportsContainer");

    var allReports = [
        {
            category: "Get Started Reports",
            reports: {
                "Insurance-Light": "Insurance Light",
                "BillingStatement": "Billing Statement",
                "Order": "Order",
                "InsuranceWithSelectingCountry": "Insurance By Country",
                "ServiceInvoice": "Service Invoice",
                "Quotation": "Quotation",
                "BusinessInvoice": "Business Invoice"
            }
        },
        {
            category: "Basic Reports",
            reports: {
                "SimpleList": "Simple List",
                "TwoSimpleLists": "Two Simple Lists",
                "HighlightCondition": "Highlight Condition",
                "Shapes": "Shapes",
                "Images": "Images",
                "Watermark": "Watermark",
                "BarCodes": "Bar-Codes",
                "HtmlTags": "Html-Tags",
                "Invoice": "Invoice",
                "Indicators": "Indicators"
            }
        },
        {
            category: "Reports with Columns",
            reports: {
                "MultiColumnList": "Multi-Column List",
                "MultiColumnBandsAcrossThenDown": "Multi-Column Bands - Across then Down",
                "MultiColumnBandsDownThenAcross": "Multi-Column Bands - Down then Across",
                "Labels": "Labels"
            }
        },
        {
            category: "Master-Detail Reports",
            reports: {
                "MasterDetail": "Master-Detail",
                "MasterDetailSubdetail": "Master-Detail-Subdetail",
                "MasterDetailWithColumns": "Master-Detail with Columns",
                "TwoMastersOnOneDetail": "Two Masters on One Detail",
                "MasterDetailWithZeroHeight": "Master-Detail with Zero Height",
                "MasterDetailOnDataBand": "Master-Detail on DataBand"
            }
        },
        {
            category: "Reports with Groups",
            reports: {
                "SimpleGroup": "Simple Group",
                "NestedGroups": "Nested Groups",
                "MasterDetailWithGroups": "Master-Detail with Groups",
                "MultiColumnGroup": "Multi-Column Group",
                "AllGroupFootersAtEnd": "All Group Footers at End",
                "InvoiceWithGroups": "Invoice with Groups",
                "SalesInvoice": "Sales Invoice"
            }
        },
        {
            category: "Hierarchical Reports",
            reports: {
                "Tree": "Tree",
                "TreeWithHeadersAndFooters": "Tree with Headers and Footers",
                "TreeWithTotals": "Tree with Totals",
                "TreeWithTotalsAllLevels": "Tree with Totals - All Levels",
                "TreeWithLockedComponents": "Tree with Locked Components"
            }
        },
        {
            category: "Parameters",
            reports: {
                "ParametersDetailedCategories": "Detailed Categories",
                "ParametersDetailedOrders": "Detailed Orders",
                "ParametersHighlightCondition": "Highlight Condition",
                "ParametersSelectingCountry": "Selecting Country",
                "ParametersInvoice": "Invoice",
                "ParametersDependentParameter": "Dependent Parameter"
            }
        },
        {
            category: "Interactive Reports",
            reports: {
                "ListOfProducts": "List of Products",
                "CrossTabWithDetailing": "Cross-Tab with Detailing",
                "Sorting": "Sorting",
                "TableWithSorting": "Table with Sorting",
                "GroupWithCollapsing": "Group with Collapsing",
                "GroupWithCollapsingWithoutFooter": "Group with Collapsing without Footer",
                "MasterDetailWithCollapsing": "Master-Detail with Collapsing",
                "EditableReport": "Editable",
                "BookmarksAndHyperlinks": "Bookmarks and Hyperlinks"
            }
        },
        {
            category: "Table",
            reports: {
                "TableSimpleTable": "Simple Table",
                "TableMasterDetailSubdetail": "Master-Detail-Subdetail",
                "TableSimpleGroup": "Simple Group",
                "TableInvoiceWithGroups": "Invoice with Groups",
                "TableImages": "Images",
                "TableFixedWidthOfColumns": "Fixed Width of Columns"
            }
        },
        {
            category: "Charts",
            reports: {
                "SimpleChart": "Simple Chart",
                "MultipleSeries": "Multiple Series",
                "ChartOnDataband": "Chart on Databand",
                "ChartsWithNegatives": "Charts with Negatives",
                "PieChart": "Pie Chart",
                "GanttChart": "Gantt Chart",
                "SteppedChart": "Stepped Chart",
                "LineChart": "Line Chart",
                "AreaChart": "Area Chart",
                "CombinedCharts": "Combined Charts",
                "TreeMapChart": "Tree-Map Chart"
            }
        },
        {
            category: "Cross-Tabs",
            reports: {
                "StandardCrossTab": "Standard Cross-Tab",
                "CrossTabWithoutColumns": " Cross-Tab without Columns",
                "CrossTabWithoutRows": "Cross-Tab without Rows",
                "CrossTabWithHighlightCondition1": "Cross-Tab with Highlight Condition 1",
                "CrossTabWithHighlightCondition2": "Cross-Tab with Highlight Condition 2",
                "CrossTabOnDataBand": "Cross-Tab on DataBand",
                "CrossTabOnPage": "Cross-Tab on Page"
            }
        },
        {
            category: "Empty Rows",
            reports: {
                "EmptyRowsSimpleList": "Simple List",
                "EmptyRowsMasterDetail": " Master-Detail",
                "EmptyRowsInvoice": "Invoice"
            }
        },
        {
            category: "Panels",
            reports: {
                "PanelsSideBySideLists": "Side-by-Side Lists",
                "PanelsSideBySideGroups": "Side-by-Side Groups",
                "PanelsMultiPanels": "Multi-Panels",
                "PanelsMasterDetailCards": "Master-Detail Cards"
            }
        },
        {
            category: "Sub-Reports",
            reports: {
                "SubReportsSideBySideLists": "Side-by-Side Lists",
                "SubReportsSideBySideListsOnDataBand": "Side-by-Side Lists on DataBand",
                "SubReportsSideBySideGroups": "Side-by-Side Groups",
                "SubReportsMasterDetail": "Master-Detail"
            }
        },
        {
            category: "Real-life Reports",
            reports: {
                "AlibabaRevenueStats": "Alibaba Revenue Stats",
                "BRICGDPStats": "BRIC GDP Stats",
                "ChinaConstructionBank": "China Construction Bank",
                "ChinasExpensiveBuildings": "China's Expensive Buildings",
                "ManufactureInChina": "Manufacture in China",
                "PopulationInChina": "Population in China",
                "StatisticsAndForecastOfChinaGDP": "Statistics and Forecast of China GDP",
                "TaiwanConstructionService": "Taiwan Construction Service",
                "TopCountriesByGDPIn2019": "Top Countries by GDP in 2019",
                "SwitzerlandInvoice": "Switzerland Invoice",
                "AutosAndLightTrucksUnitsSalesInUSA": "Autos Units Sales in USA",
                "EmployeeCards": "Employee Cards",
                "Payroll": "Payroll",
                "VehicleSalesWorldwide": "Vehicle Sales Worldwide"
            }
        }
    ]

    for (var i = 0; i < allReports.length; i++) {
        reportsContainer.appendChild(stiCategoryHeader(allReports[i].category));

        for (var reportName in allReports[i].reports) {
            var button = stiReportButton(allReports[i].reports[reportName], "/Content/Images/Report_x2.png");
            reportsContainer.appendChild(button);
            button.reportName = reportName;
            button.id = reportName;
            reportButtonsId.push(button.id);
        }
    }
}

function stiReportButton(text, imageName) {
    var button = document.createElement("div");
    button.className = "stiReportButton";
    button.style.display = "block";
    button.style.cursor = "pointer";

    var table = document.createElement("table");
    table.cellPadding = 0;
    table.cellSpacing = 0;
    button.appendChild(table);

    var tr = document.createElement("tr");
    table.appendChild(tr);

    if (imageName) {
        var img = document.createElement("img");
        img.style.width = img.style.height = "18px";
        img.style.margin = "5px 5px 5px 8px";
        img.src = imageName;

        var imageCell = document.createElement("td");
        tr.appendChild(imageCell);
        imageCell.appendChild(img);
    }

    if (text) {
        var textCell = document.createElement("td");
        textCell.style.whiteSpace = "nowrap";
        textCell.innerHTML = text;
        tr.appendChild(textCell);
    }

    button.onmouseover = function () {
        this.className = "stiReportButtonOver";
    }

    button.onmouseout = function () {
        this.className = button.isSelected ? "stiReportButtonSelected" : "stiReportButton";
    };

    button.onclick = function () {
        loadReportToViewer(this.reportName);
    }

    return button;
}

function mainFrameLoadComplete() {
    hideProgress();
}

function setSelectedReportButton(reportName) {
    for (i = 0; i < reportButtonsId.length; i++) {
        var reportButton = document.getElementById(reportButtonsId[i]);
        if (reportButton) {
            reportButton.isSelected = reportButtonsId[i] == reportName;
            reportButton.className = reportButton.isSelected ? "stiReportButtonSelected" : "stiReportButton";
        }
    }
}

function loadReportToViewer(reportName) {
    setSelectedReportButton(reportName);

    var mainFrame = document.getElementById("stiMainFrame");
    mainFrame.src = "/View/Reports/" + reportName;
    showProgress();
}

function stiCategoryHeader(text) {
    var header = document.createElement("div");
    header.className = "stiCategoryHeader";
    header.innerHTML = text;

    return header;
}

function stiProgress() {
    var progressContainer = document.createElement("div");
    progressContainer.className = "stiProgressContainer";

    var progress = document.createElement("div");
    progressContainer.appendChild(progress);
    progress.className = "mobile_designer_loader";

    return progressContainer;
}

function showProgress() {
    hideProgress();
    var rightPanel = document.getElementById("RightPanel");
    var progress = stiProgress();
    rightPanel.appendChild(progress);
    rightPanel.progress = progress;
}

function hideProgress() {
    var rightPanel = document.getElementById("RightPanel");
    if (rightPanel.progress) {
        rightPanel.removeChild(rightPanel.progress);
        rightPanel.progress = null;
    }
}