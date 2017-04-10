﻿$(function () {
    debugger;
    $("#grid").jqGrid
        ({
            url: "/Birds/GetSurveyors",
            datatype: 'json',
            mtype: 'Get',
            //table header name   
            colNames: ['SurveyorID', 'Surveyor Name', 'Is Active'],
            //prmNames is needed to send the id to the controller
            prmNames: { id: "SurveyorID" },
            //colModel takes the data from controller and binds to grid   
            colModel: [
                {
                    key: true,
                    hidden: true,
                    name: 'SurveyorID',
                    index: 'SurveyorID',                    
                    defaultValue: 0
                }, {
                    key: false,
                    name: 'SurveyorName',
                    index: 'SurveyorName',
                    editable: true
                }, {
                    key: false,
                    name: 'SurveyorActive',
                    index: 'SurveyorActive',
                    editable: true,
                    edittype: 'checkbox',
                    editoptions: { value: "true:false" }
                }],

            pager: jQuery('#pager'),
            rowNum: 10,
            rowList: [10, 20, 30, 40],
            height: '100%',
            viewrecords: true,
            caption: 'Bird surveyors',
            emptyrecords: 'No records to display',
            jsonReader:
            {
                root: "rows",
                page: "page",
                total: "total",
                records: "records",
                repeatitems: false,
                Id: "0"
            },
            autowidth: true,
            multiselect: false
            //pager-you have to choose here what icons should appear at the bottom  
            //like edit,create,delete icons  
        }).navGrid('#pager',
        {
            edit: true,
            add: true,
            //del: true,
            search: false,
            refresh: true
        }, {
            // edit options  
            zIndex: 100,
            url: '/Birds/EditSurveyor',
            closeOnEscape: true,
            closeAfterEdit: true,
            recreateForm: true,
            afterComplete: function (response) {
                if (response.responseText) {                   
                    $("#successMsgDiv").text(response.responseText);
                    $("#successMsgDiv").show();
                }
            }
        }, {
            // add options  
            zIndex: 100,
            url: "/Birds/CreateSurveyor",
            closeOnEscape: true,
            closeAfterAdd: true,
            afterComplete: function (response) {
                if (response.responseText) {                   
                    $("#successMsgDiv").text(response.responseText);
                    $("#successMsgDiv").show();
                }
            }
        //}, {
        //    // delete options  
        //    zIndex: 100,
        //    url: "/Jqgrid/Delete",
        //    closeOnEscape: true,
        //    closeAfterDelete: true,
        //    recreateForm: true,
        //    msg: "Are you sure you want to delete this task?",
        //    afterComplete: function (response) {
        //        if (response.responseText) {
        //            alert(response.responseText);
        //        }
        //    }
        });
});  