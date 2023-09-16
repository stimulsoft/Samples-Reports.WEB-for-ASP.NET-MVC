var reportButtonsId = [];

function createReportsButtons() {
    var reportsContainer = document.getElementById("stiReportsContainer");

    var allReports = [
        {
            category: "Get Started Reports",
            reports: {
                "BillingStatement": "Billing Statement",
                "Order": "Order",
                "InsuranceWithSelectingCountry": "Insurance By Country",
                "ServiceInvoice": "Service Invoice",
                "Quotation": "Quotation",
                "BusinessInvoice": "Business Invoice",
                "SwitzerlandInvoice": "Switzerland Invoice"
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
                "Indicators": "Indicators"
            }
        },
        {
            category: "Reports with Columns",
            reports: {
                "MultiColumnList": "Multi-Column List",
                "MultiColumnBandsAcrossThenDown": "Multi-Column Bands - Across then Down",
                "MultiColumnBandsDownThenAcross": "Multi-Column Bands - Down then Across",
                "VehicleProductionLabels": "Vehicle Production Labels"
            }
        },
        {
            category: "Master-Detail Reports",
            reports: {
                "MasterDetail": "Master-Detail",
                "MasterDetailSubdetail": "Master-Detail-Subdetail",
                "MasterDetailWithColumns": "Master-Detail with Columns",
                "TwoMastersOnOneDetail": "Two Masters on One Detail",
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
                "AllGroupFootersAtEnd": "All Group Footers at End"
            }
        },
        {
            category: "Hierarchical Reports",
            reports: {
                "Tree": "Tree",
                "TreeWithTotals": "Tree with Totals",
                "TreeWithTotalsAllLevels": "Tree with Totals - All Levels",
                "TreeWithLockedComponents": "Tree with Locked Components"
            }
        },
        {
            category: "Parameters",
            reports: {
                "ParametersDetailedCategories": "Detailed Categories",
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
                "GroupWithCollapsing": "Group with Collapsing",
                "EditableReport": "Editable",
                "BookmarksAndHyperlinks": "Bookmarks and Hyperlinks"
            }
        },
        {
            category: "Table",
            reports: {
                "TableSimpleTable": "Simple Table",
                "TableSimpleGroup": "Simple Group",
                "TableFixedWidthOfColumns": "Fixed Width of Columns"
            }
        },
        {
            category: "Real-life Charts",
            reports: {
                "GlobalGrowth": "Global Growth",
                "MigrationByDecadeInUSA": "Migration By Decade In USA",
                "NaturalGasProduction": "Natural Gas Production",
                "TopAutoSalesInUSA16": "Top Auto Sales In USA 16"
            }
        },
        {
            category: "Charts",
            reports: {
                "3DPie": "3D Pie",
                "Area": "Area",
                "Bubble": "Bubble",
                "ClusteredBar": "Clustered Bar",
                "ClusteredColumn": "Clustered Column",
                "Doughnut": "Doughnut",
                "Financial": "Financial",
                "Funnel": "Funnel",
                "Gantt": "Gantt",
                "Histogram": "Histogram",
                "Line": "Line",
                "Pareto": "Pareto",
                "Pictorial": "Pictorial",
                "Pie": "Pie",
                "Radar": "Radar",
                "Range": "Range",
                "Scatter": "Scatter",
                "Stepped": "Stepped",
                "Sunburst": "Sunburst",
                "Treemap": "Treemap",
                "Waterfall": "Waterfall",
            }
        },
        {
            category: "Cross-Tabs",
            reports: {
                "StandardCrossTab": "Standard Cross-Tab",
                "CrossTabWithoutColumns": " Cross-Tab without Columns",
                "CrossTabWithoutRows": "Cross-Tab without Rows",
                "CrossTabWithHighlightCondition1": "Cross-Tab with Highlight Condition",
                "CrossTabAndCrossBands": "Cross-Tab and Cross Bands",
                "CrossTabOnPage": "Cross-Tab on Page"
            }
        },
        {
            category: "Empty Rows",
            reports: {
                "EmptyRowsMasterDetail": " Master-Detail",
                "EmptyRowsInvoice": "Invoice"
            }
        },
        {
            category: "Panels",
            reports: {
                "PanelsSideBySideLists": "Side-by-Side Lists",
                "PanelsSideBySideGroups": "Side-by-Side Groups"
            }
        },
        {
            category: "Sub-Reports",
            reports: {
                "SubReportsSideBySideListsOnDataBand": "Side-by-Side Lists on DataBand",
                "SubReportsMasterDetail": "Master-Detail"
            }
        },
        {
            category: "Table Of Contents",
            reports: {
                "MasterDetailReportWithTOC": "Master-Detail Report With TOC",
                "MultiColumnListWithTOC": "Multi-Column List With TOC",
                "PanelsWithTOC": "Panels With TOC",
                "TableWithTOC": "Table With TOC"
            }
        },
        {
            category: "Real-life Reports",
            reports: {
                "AlibabaRevenueStats": "Alibaba Revenue Stats",
                "BRICGDPStats": "BRIC GDP Stats",
                "ChinaConstructionBank": "China Construction Bank",
                "ManufactureInChina": "Manufacture in China",
                "TopCountriesByGDPIn2019": "Top Countries by GDP in 2019",
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