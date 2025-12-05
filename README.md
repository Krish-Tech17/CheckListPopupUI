# 📘 Reusable Popup & Checklist UI Submodule (Unity)

A fully **modular**, **drag-and-drop**, and **workflow-agnostic** UI submodule for Unity.

This package provides two reusable UI systems:

* **Popup System** – OK/Close popups, Yes/No confirmations
* **Checklist System** – scrollable, supports required items, pre-checked items, and callbacks

Suitable for **AR/VR workflows**, **training modules**, **enterprise apps**, or **any Unity system** that requires standard popups and checklists.

This module is designed to be **independent**, **clean**, and **easy to integrate** into any Unity project.

---

# 📁 Folder Overview

```
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
```

---

# 🌟 Key Features

### ✔ Modular & Reusable

Drop the prefabs into any Unity Canvas and call the API.
No dependencies. No setup complexity.

### ✔ Three Popup Types

* **Close Button-only popup**
* **OK + Close Button popup**
* **Yes/No confirmation popup**

### ✔ Checklist System

Includes:

* Required items
* Pre-checked items
* Scroll View list
* Automatic item pooling
* Submit & Close callbacks

### ✔ Callback-Based

Your logic receives:

* `OnYes`, `OnNo`, `OnOk`, `OnClose`
* `OnChecklistSubmitted`
* `OnChecklistClosed`

### ✔ Mobile-Friendly & Responsive

Works well for **touchscreens**, **AR**, **VR**, and **small-screen devices**.

---

# 🧩 Components in Detail

## 1️⃣ PopUpHandler.cs

The **main controller** for popup UI.

### Responsibilities

* Show/Hide popup
* Update title & message
* Connect Close/OK/Yes/No buttons
* Trigger user callbacks
* Manage three popup types

### Supported Popup Types

* Close button only
* OK + Close
* Yes/No confirmation

### Public API

```csharp
void ShowPopup(
    string title,
    string message,
    Action onOk,
    Action onClose,
    bool showOkButton
);

void ShowYesNoPopup(
    string title,
    string message,
    Action onYes,
    Action onNo,
    Action onClose
);

void HidePopup();
```

---

## 2️⃣ ChecklistController.cs

Controls the scrollable checklist UI.

### Responsibilities

* Generate checklist items dynamically
* Apply required and pre-checked states
* Validate submission
* Trigger Submit/Close callbacks

### Public API

```csharp
void Show(
    string title,
    List<ChecklistData> checklistItems,
    Action<List<ChecklistData>> onSubmit,
    Action onClose
);

void Hide();
```

---

## 3️⃣ ChecklistData.cs

Represents a single checklist entry.

### Fields

```csharp
public string id;             // Unique identifier
public string label;          // Displayed text
public bool required;         // Must be checked to submit
public bool alreadychecked;   // Pre-selected
```

---

# 📝 Popup Usage

### ✔ Close-only popup

```csharp
PopUpHandler.Instance.ShowPopup(
    title,
    message,
    ProceedToNextStep,
    OnCloseButtonClicked,
    false
);
```

### ✔ OK popup

```csharp
PopUpHandler.Instance.ShowPopup(
    title,
    message,
    ProceedToNextStep,
    OnCloseButtonClicked,
    true
);
```

### ✔ Yes/No popup

```csharp
PopUpHandler.Instance.ShowYesNoPopup(
    title,
    message,
    OnYesButtonClicked,
    OnNoButtonClicked,
    OnCloseButtonClicked
);
```

---

# 🧾 Checklist Data Structure

### Example Checklist

```csharp
List<ChecklistData> testList = new List<ChecklistData>()
{
    new ChecklistData { id="C1", label="Check Battery Status", required=true, alreadychecked=false },
    new ChecklistData { id="C2", label="Clean Camera Lens", required=false, alreadychecked=true },
};
```

---

# 📋 Checklist Usage

```csharp
ChecklistController.Instance.Show(
    "Preflight Checklist",
    testList,
    OnChecklistSubmitted,
    OnChecklistClosed
);
```

### Callback Outputs

* `OnChecklistSubmitted(List<ChecklistData> completedItems)`
* `OnChecklistClosed()`

---

# 🔧 Integration Steps

## **Step 1 — Add Prefabs to Canvas**

Drag these into any Canvas:

* `PopupPrefab.prefab`
* `ChecklistPanel.prefab`

Keep them **enabled** but visually hidden (handled by script).

---

## **Step 2 — Ensure Singleton Instances Exist**

Both:

* `PopUpHandler`
* `ChecklistController`

use singleton patterns.
As long as one copy exists in the scene, the system will work.

---

## **Step 3 — Call Public APIs**

### Show a popup:

```csharp
PopUpHandler.Instance.ShowPopup("Alert", "Task saved!", null, null, true);
```

### Show a checklist:

```csharp
ChecklistController.Instance.Show(
    "Checklist",
    testList,
    SubmitCallback,
    CloseCallback
);
```

---

# 🎬 Demo Scene

`Demo_Reusable Popup Checklist.unity`

Shows:

* All popup variations
* Checklist logic
* Submit & Close flow

Useful for onboarding and understanding the UI lifecycle.

---

# 🧠 Design Philosophy

### ✔ UI separated from logic

The visual elements remain generic and reusable.

### ✔ Callback-driven

Workflows receive events without altering core scripts.

### ✔ Zero dependencies

Works across:

* AR Foundation
* VR
* Mobile
* Desktop

### ✔ Extensible

Add animations, audio, or themes without changing main scripts.

---

# 🏁 Conclusion

The **Popup & Checklist Submodule** provides:

✔ Ready-to-use UI
✔ Clean and flexible API
✔ Multiple popup types
✔ Scrollable checklist system
✔ Required/pre-checked logic
✔ Reusable prefab structure
✔ Zero dependencies
✔ Easy integration into any Unity workflow
