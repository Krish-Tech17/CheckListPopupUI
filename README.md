📘 Reusable Popup & Checklist UI Submodule (Unity)

A fully modular, drag-and-drop, and workflow-agnostic UI submodule for Unity projects.
This package provides two reusable components:

Popup System – multiple popup types (OK, Close, Yes/No)

Checklist System – scrollable list with required items, pre-checked items, and callbacks

Suitable for AR/VR workflows, training modules or any system needing standard popups and checklists.

This submodule is designed to be independent, clean, and easy to integrate into any Unity project.

ChecklistPopupUI/
│
├── Prefab/
│   ├── ChecklistItem.prefab
│   ├── ChecklistPanel.prefab
│   └── PopupPrefab.prefab
│
├── Scenes/
│   └── Demo_Reusable Popup Checklist.unity
│
├── Script/
│   ├── Checklist/
│   │   ├── ChecklistController.cs
│   │   ├── ChecklistItemPool.cs
│   │   ├── ChecklistItemUI.cs
│   │   └── LoadData.cs
│   │
│   ├── Popup/
│   │   ├── Debugger.cs
│   │   └── PopUpHandler.cs
│
├── UI/
│   ├── ButtonLayout.png
│   └── CloseIcon.png
│
└── README.md


🌟 Key Features
✔ Modular & Reusable

Drop the prefab into any Unity Canvas and call the API — no external dependencies.

✔ Three Popup Types

Built-in support for:

Close button-only popup

OK button and close button popup

Yes/No confirmation popup

✔ Checklist System

Includes:

Required items

Pre-checked items

Scroll View list

Automatic item pooling and instantiation

Submit & close actions

✔ Callback-Based

Your logic receives:

OnYes

OnNo

OnOk

OnClose

OnChecklistSubmitted

OnChecklistClosed

✔ Mobile-Friendly UI

Designed for touchscreen workflows and responsive scaling.

🧩 Components in Detail
1️⃣ PopUpHandler.cs

The main controller for popup UI.

Responsibilities:

Show/Hide popup

Update title & message

Connect buttons (Close / OK / Yes / No)

Trigger callback methods

Popup Types Supported:

Simple popup with close button

Simple popup with OK button

Yes/No confirmation popup

Public API:
void ShowPopup(string title, string message, 
               Action onOk, Action onClose, bool showOkButton);

void ShowYesNoPopup(string title, string message, 
                     Action onYes, Action onNo, Action onClose);

void HidePopup();

2️⃣ ChecklistController.cs

Controls the scrollable checklist panel.

Responsibilities:

Generate checklist items

Handle required & pre-checked conditions

Submit validation

Call close/submit callbacks

Public API:
void Show(string title, List<ChecklistData> checklistItems,
          Action<List<ChecklistData>> onSubmit, Action onClose);

void Hide();

3️⃣ ChecklistData.cs

The data structure for each checklist item.

Fields:
public string id;             // Unique ID for each entry
public string label;          // Visible text in UI
public bool required;         // Must be checked to submit
public bool alreadychecked;   // Pre-selected state

📝 Popup Usage
✔ Simple popup with close button only
PopUpHandler.Instance.ShowPopup(
    title,
    message,
    ProceedToNextStep,
    OnCloseButtonClicked,
    false
);

✔ Simple popup with OK button only
PopUpHandler.Instance.ShowPopup(
    title,
    message,
    ProceedToNextStep,
    OnCloseButtonClicked,
    true
);

✔ Yes/No confirmation popup
PopUpHandler.Instance.ShowYesNoPopup(
    title,
    message,
    OnYesButtonClicked,
    OnNoButtonClicked,
    OnCloseButtonClicked
);

🧾 Checklist Data Structure

Each checklist item includes:

Field	Description
id	Unique identifier for the checklist entry
label	The text shown beside the toggle
required	Must be checked before submission
alreadychecked	Pre-selected when checklist opens
Example:
List<ChecklistData> testList = new List<ChecklistData>()
{
    new ChecklistData { id="C1", label="Check Battery Status", required=true, alreadychecked=false },
    new ChecklistData { id="C2", label="Clean Camera Lens", required=false, alreadychecked=true },
    // add more...
};

📋 Checklist Usage

Display a checklist using:

ChecklistController.Instance.Show(
    "Preflight Checklist", 
    testList, 
    OnChecklistSubmitted, 
    OnChecklistClosed
);


The callbacks provide:

OnChecklistSubmitted(List<ChecklistData> completedItems)

OnChecklistClosed()

🔧 Integration Steps
Step 1 — Add Prefabs to Canvas

Drag these into your scene:

Popup.prefab

ChecklistPanel.prefab

Ensure both remain active in the hierarchy (can start hidden).

Step 2 — Assign Script References

Both handlers use singleton logic (Instance), so no configuration is required beyond ensuring one instance exists.

Step 3 — Call the Public APIs

From any script:

Show a popup:
PopUpHandler.Instance.ShowPopup("Alert", "Task saved!", null, null, true);

Show a checklist:
ChecklistController.Instance.Show("Checklist", testList, SubmitCallback, CloseCallback);

🎬 (Optional) Demo Scene

The included UIReusable_Demo.unity demonstrates:

Showing popups of all types

Displaying checklists

Submitting & closing logic

Useful for onboarding developers into the UI module workflow.

🧠 Design Philosophy

This submodule is built with clarity, reusability, and independence in mind.

✔ UI separated from logic

Popup & checklist visuals remain generic and reusable.

✔ Callback-driven

Your workflow receives events without modifying the core scripts.

✔ No dependencies

Works across:

AR Foundation

VR

Mobile

Desktop

Hybrid workflows

✔ Easy to extend

Add animations, transitions, or sound effects without modifying core code.

📁 Folder Overview
ChecklistPopupUI/
│
├── Prefab/
│   ├── ChecklistItem.prefab
│   ├── ChecklistPanel.prefab
│   └── PopupPrefab.prefab
│
├── Scenes/
│   └── Demo_Reusable Popup Checklist.unity
│
├── Script/
│   ├── Checklist/
│   │   ├── ChecklistController.cs
│   │   ├── ChecklistItemPool.cs
│   │   ├── ChecklistItemUI.cs
│   │   └── LoadData.cs
│   │
│   ├── Popup/
│   │   ├── Debugger.cs
│   │   └── PopUpHandler.cs
│
├── UI/
│   ├── ButtonLayout.png
│   └── CloseIcon.png
│
└── README.md


🏁 Conclusion

The Popup & Checklist Submodule provides:

✔ Ready-to-use UI

✔ Clean and flexible API

✔ Multiple popup types

✔ Scrollable checklist with required/pre-checked logic

✔ Reusable prefab structure

✔ Zero dependencies