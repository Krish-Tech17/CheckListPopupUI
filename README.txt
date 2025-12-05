Reusable UI components: Popup & Checklist

This module provides two reusable UI components for Unity:

> Popup System – Supports:

Simple popup with close button only
Simple OK button only popup
Yes/No confirmation popup

> Checklist System – Displays a scrollable list of checklist items with:

Required items
Pre-checked items
Submit and close button

=============================

Popup usage:

Simple popup with close button: PopUpHandler.Instance.ShowPopup(title, message, ProceedToNextStep, OnCloseButtonClicked, false);
Simple popup with ok button: PopUpHandler.Instance.ShowPopup(title, message, ProceedToNextStep, OnCloseButtonClicked, true);
Yes/No confirmation popup: PopUpHandler.Instance.ShowPopup(title, message, onYesButtonClicked, onNoButtonClicked, OnCloseButtonClicked);

============================

Checklist data structure:

id: Unique id against each label.
label: Options in the checklist.
required: Labels that are required to be checked before submitting.
alreadychecked: Labels that are alreadychecked while the checklist is displayed.

=============================

Checklist usage:

List<ChecklistData> testList = new List<ChecklistData>()
{
    new ChecklistData { id="C1", label="Check Battery Status", required=true, alreadychecked=false },
    new ChecklistData { id="C2", label="Clean Camera Lens", required=false, alreadychecked=true },
    // add more items...
};


ChecklistController.Instance.Show("Preflight Checklist", testList, OnChecklistSubmitted, OnChecklistClosed);