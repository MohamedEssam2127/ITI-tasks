# TaskCurator — Project Documentation

> An Angular 21 Task Management application with full CRUD, authentication, and reactive state management.

---

## Table of Contents

1. [Project Overview](#1-project-overview)
2. [Tech Stack & Dependencies](#2-tech-stack--dependencies)
3. [Project Structure](#3-project-structure)
4. [Design System (Global CSS)](#4-design-system-global-css)
5. [Data Models & Types](#5-data-models--types)
6. [Backend (JSON Server)](#6-backend-json-server)
7. [Application Bootstrap](#7-application-bootstrap)
8. [Routing](#8-routing)
9. [Auth Guard](#9-auth-guard)
10. [Services](#10-services)
11. [Components](#11-components)
12. [Pages](#12-pages)
13. [Component Interaction Diagram](#13-component-interaction-diagram)
14. [Running the Project](#14-running-the-project)

---

## 1. Project Overview

**TaskCurator** is a dark-mode Angular SPA (Single-Page Application) that allows authenticated users to manage personal todo tasks. Key features include:

- User **Sign Up** and **Sign In** with form validation.
- **Auth Guard** protecting private routes (home, add task, task list).
- **Add Task** form with priority selection, due date, and tags.
- **Task List** with live filtering (All / Done / Not Done) via a Tabs component.
- **Card** view for each task with inline editing, delete, and toggle-done.
- **Toast** notification system for all CRUD events.
- **Image Gallery** (auto-sliding) on the home dashboard.
- **Flame** component in the header to represent a streak indicator.
- Reactive state via Angular **Signals**.
- Global logout from the header.

---

## 2. Tech Stack & Dependencies

| Category | Package | Version |
|---|---|---|
| Framework | `@angular/core` | ^21.2.0 |
| HTTP | `@angular/common/http` | ^21.2.0 |
| Forms | `@angular/forms` | ^21.2.0 |
| Router | `@angular/router` | ^21.2.0 |
| Icons | `@fortawesome/fontawesome-free` | ^7.2.0 |
| Reactive Extensions | `rxjs` | ~7.8.0 |
| UUID Generation | `uuid` | ^13.0.0 |
| Mock API | `json-server` (via `db.json`) | — |
| Language | TypeScript | ~5.9.2 |
| Build Tool | `@angular/build` | ^21.2.7 |
| Linting / Formatting | `prettier` | ^3.8.1 |
| Testing | `vitest` | ^4.0.8 |

### npm scripts

```bash
npm start       # ng serve  (dev server)
npm run build   # ng build  (production bundle)
npm run watch   # ng build --watch --configuration development
npm test        # ng test
```

---

## 3. Project Structure

```
D01/
├── db.json                          # JSON Server mock database
├── package.json
├── angular.json
├── tsconfig.json
├── tsconfig.app.json
├── tsconfig.spec.json
├── .prettierrc
├── public/                          # Static assets (images for gallery + empty-state)
└── src/
    ├── index.html                   # Root HTML shell
    ├── main.ts                      # Angular bootstrap entry point
    ├── styles.css                   # Global design system / CSS variables
    └── app/
        ├── app.ts                   # Root component (App)
        ├── app.html                 # Root template (header + router-outlet + toast + footer)
        ├── app.css                  # Root component styles
        ├── app.config.ts            # Application providers (router, HttpClient)
        ├── app.routes.ts            # Route definitions (lazy loaded)
        ├── auth-guard.ts            # CanActivateFn guard
        ├── types.ts                 # Shared TypeScript interfaces & types
        ├── services/
        │   ├── todoApi.ts           # TodoApi — CRUD operations for todos
        │   ├── userApi.ts           # UserApi — user auth & isLoggedIn signal
        │   └── toastservice.ts      # ToastService — global toast notifications
        ├── components/
        │   ├── Header/              # App header with nav, auth buttons, flame, avatar
        │   ├── Footer/              # App footer
        │   ├── card/                # Single task card (view + inline edit)
        │   ├── task-list/           # Task list (tabs + cards grid)
        │   ├── task-input/          # Add task form
        │   ├── tabs-component/      # Filter tabs (All / Done / Not Done)
        │   ├── toast/               # Global toast notification display
        │   ├── gallary/             # Auto-sliding image gallery (home dashboard)
        │   └── flame/               # Streak flame indicator (header)
        └── pages/
            ├── home-dashboard/      # Authenticated home page (gallery + summary cards)
            ├── signin/              # Sign In page
            ├── signup/              # Sign Up page
            └── not-found/           # 404 page
```

---

## 4. Design System (Global CSS)

File: `src/styles.css`

All global design tokens are defined as CSS custom properties on `:root`.

### Color Tokens

| Variable | Value | Usage |
|---|---|---|
| `--bg-deep` | `#121417` | Page background |
| `--bg-container` | `#1A1D21` | Card / container backgrounds |
| `--bg-input` | `#22252A` | Input field backgrounds |
| `--bg-elevated` | `#262A30` | Elevated surfaces |
| `--accent` | `#A5B4FC` | Primary accent (indigo) |
| `--accent-hover` | `#818CF8` | Accent on hover |
| `--accent-dim` | `rgba(165,180,252,0.1)` | Subtle accent fill |
| `--text-primary` | `#F1F5F9` | Main text |
| `--text-secondary` | `#94A3B8` | Secondary text |
| `--text-muted` | `#64748B` | Muted / placeholder text |
| `--border-subtle` | `rgba(255,255,255,0.06)` | Borders |
| `--success` | `#10B981` | Success state (green) |
| `--update` | `#3B82F6` | Update state (blue) |
| `--error` | `#EF4444` | Error state (red) |
| `--warning` | `#F59E0B` | Warning state (amber) |

### Shadow Tokens

| Variable | Value |
|---|---|
| `--shadow-deep` | `0 10px 30px rgba(0,0,0,0.5)` |
| `--shadow-card` | `0 8px 24px rgba(0,0,0,0.4)` |
| `--shadow-elevated` | `0 20px 50px rgba(0,0,0,0.6)` |

### Border Radius Tokens

| Variable | Value |
|---|---|
| `--radius-sm` | `8px` |
| `--radius-md` | `12px` |
| `--radius-lg` | `16px` |
| `--radius-xl` | `20px` |
| `--radius-full` | `9999px` |

### Other Tokens

| Variable | Value |
|---|---|
| `--font` | `'Inter', -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif` |
| `--transition-smooth` | `all 0.3s cubic-bezier(0.4, 0, 0.2, 1)` |
| `--gradient-hero` | `linear-gradient(135deg, #0d9488 … #a7f3d0)` |

---

## 5. Data Models & Types

File: `src/app/types.ts`

### `ToDo` interface

```ts
export interface ToDo {
  id: string;
  title: string;
  description: string;
  priority: string;       // 'Low' | 'Medium' | 'High'
  date: string;           // ISO date string (YYYY-MM-DD)
  tags: string;
  isSDone: boolean;       // true = completed task
  userEmail: string;      // owner's email (for user-scoped filtering)
}
```

### `User` interface

```ts
export interface User {
  username: string;
  email: string;
  password: string;
  id: string;
}
```

### `FilterType`

```ts
export type FilterType = 'all' | 'done' | 'notDone';
```

### `ToastType`

```ts
export type ToastType = 'success' | 'delete' | 'update' | 'done' | 'nothing';
```

---

## 6. Backend (JSON Server)

File: `db.json`

The app uses **JSON Server** as a REST API mock running on `http://localhost:3000`.

### Endpoints

| Method | URL | Description |
|---|---|---|
| `GET` | `/users` | Fetch all users |
| `POST` | `/users` | Register a new user |
| `GET` | `/todos` | Fetch all todos |
| `GET` | `/todos?userEmail=<email>` | Fetch todos scoped to a user |
| `POST` | `/todos` | Create a new todo |
| `PUT` | `/todos/:id` | Update a todo by ID |
| `DELETE` | `/todos/:id` | Delete a todo by ID |

### Sample Data Shape

```json
{
  "users": [
    { "username": "essam", "email": "essam@gmail.com", "password": "123456", "id": "JghtwSMwsh4" }
  ],
  "todos": [
    {
      "id": "fBpe5_cjc1U",
      "title": "Sample Task",
      "description": "Task description",
      "priority": "Medium",
      "date": "2026-04-28",
      "tags": "work",
      "isSDone": false,
      "userEmail": "essam@gmail.com"
    }
  ]
}
```

---

## 7. Application Bootstrap

### `src/main.ts`
Bootstraps the Angular application using `bootstrapApplication(App, appConfig)`.

### `src/app/app.config.ts`
Registers global providers:
- `provideBrowserGlobalErrorListeners()` — global error listeners
- `provideRouter(routes)` — client-side routing
- `provideHttpClient()` — Angular HTTP client (for API calls)

### `src/app/app.ts` — Root Component
- Imports: `Header`, `Footer`, `RouterOutlet`, `Toast`
- Template: renders `<app-header>`, `<router-outlet>`, `<app-toast>`, `<app-footer>` in sequence.

---

## 8. Routing

File: `src/app/app.routes.ts`

All feature routes use **lazy loading** via `loadComponent`.

| Path | Component | Guard | Description |
|---|---|---|---|
| `''` | — | — | Redirects to `/home` |
| `/home` | `HomeDashboard` | `authGuard` | Authenticated home dashboard |
| `/signin` | `Signin` | — | Sign in page |
| `/signup` | `Signup` | — | Sign up / registration page |
| `/add` | `TaskInput` | `authGuard` | Add a new task form |
| `/tasks` | `TaskList` | `authGuard` | View & manage tasks |
| `**` | `NotFound` | — | 404 catch-all |

---

## 9. Auth Guard

File: `src/app/auth-guard.ts`

A functional `CanActivateFn` guard that protects private routes:

```ts
export const authGuard: CanActivateFn = () => {
  const router = inject(Router);
  const user = localStorage.getItem('user');
  if (user) return true;
  router.navigate(['/signin']);
  return false;
};
```

- Checks for a `user` key in `localStorage`.
- Redirects unauthenticated users to `/signin`.

---

## 10. Services

### `TodoApi` — `src/app/services/todoApi.ts`

Injectable service (root-level) for all todo CRUD operations.

| Member | Type | Description |
|---|---|---|
| `todos` | `Signal<ToDo[]>` | Reactive signal holding the current user's todos |
| `baseUrl` | `string` | `http://localhost:3000/todos` |
| `addTodo(todo)` | `Observable<ToDo>` | POST a new todo |
| `getAllTodos(email?)` | `Observable<ToDo[]>` | GET todos, optionally filtered by `userEmail` |
| `deleteTodo(id)` | `Observable<any>` | DELETE todo by ID |
| `updateTodo(todo)` | `Observable<ToDo>` | PUT (full replace) todo by ID |

The `todos` signal is the **single source of truth** for the task list. All mutations (add, delete, update) update this signal directly after a successful API call, ensuring the UI stays in sync without re-fetching.

---

### `UserApi` — `src/app/services/userApi.ts`

Injectable service (root-level) for user authentication.

| Member | Type | Description |
|---|---|---|
| `isLoggedIn` | `WritableSignal<boolean>` | Auth state, initialized from `localStorage` |
| `baseUrl` | `string` | `http://localhost:3000` |
| `getUsers()` | `Observable<any>` | GET all users |
| `addUser(user)` | `Observable<any>` | POST new user (register) |
| `isUserExist()` | `Observable<User[]>` | GET all users (used for signin validation) |

`isLoggedIn` is a **writable signal** used reactively across Header, Signin, and Signup components.

---

### `ToastService` — `src/app/services/toastservice.ts`

Injectable service (root-level) for global toast notifications.

| Member | Type | Description |
|---|---|---|
| `toastType` | `Signal<ToastType>` | Current active toast type |
| `showToast(type)` | `void` | Sets `toastType` and auto-clears after 3000ms |

The toast is automatically dismissed after **3 seconds**. Calling `showToast` while a toast is already active resets the timer.

---

## 11. Components

### `Header` — `src/app/components/Header/`

**Selector:** `app-header`

| Member | Type | Description |
|---|---|---|
| `isFlameVisible` | `boolean` | Controls whether the Flame icon is shown |
| `apiServer` | `UserApi` | Injected user service |
| `islogin` | `Signal<boolean>` | Alias for `apiServer.isLoggedIn` |
| `router` | `Router` | Injected router |
| `logout()` | `void` | Clears localStorage, sets `isLoggedIn` to false, navigates to `/signin` |

**Template behavior:**
- Shows nav links (Home, Tasks, Add Task).
- If logged in: shows Logout button + Flame icon + Avatar.
- If not logged in: shows Login and Register links.
- Uses `routerLink` + `routerLinkActive="active"` for nav highlighting.

---

### `Footer` — `src/app/components/Footer/`

Simple footer component (no logic).

---

### `Flame` — `src/app/components/flame/`

**Selector:** `app-flame`

| Member | Type | Description |
|---|---|---|
| `streak` | `@Input() number` | Streak count (default: 0) |
| `streakCompleted` | `@Output() EventEmitter<void>` | Emits when the component is destroyed |
| `ngOnDestroy()` | lifecycle | Emits `streakCompleted` and logs to console |

Used in the Header to display a streak/activity indicator.

---

### `Gallary` — `src/app/components/gallary/`

**Selector:** `app-gallary`

An auto-sliding image carousel shown on the home dashboard.

| Member | Type | Description |
|---|---|---|
| `images` | `string[]` | Array of image filenames (`4.jpg`, `2.webp`, `3.jpg`, `1.jpg`) |
| `active` | `number` | Index of currently displayed image |
| `intervalId` | `any` | Handle for the auto-slide interval |
| `ngOnInit()` | lifecycle | Starts the auto-slide interval |
| `ngOnDestroy()` | lifecycle | Clears the interval to prevent memory leaks |
| `right()` | `void` | Advances to next image (wraps around) |
| `left()` | `void` | Goes to previous image (wraps around) |
| `goToImage(index)` | `void` | Jumps to a specific image by dot click |

Auto-slides every **2000ms**. Provides prev/next arrow buttons and clickable dot indicators.

---

### `TabsComponent` — `src/app/components/tabs-component/`

**Selector:** `app-tabs`

| Member | Type | Description |
|---|---|---|
| `filterChanged` | `@Output() EventEmitter<FilterType>` | Emits the selected filter to parent |
| `activeTab` | `FilterType` | Currently active tab (default: `'all'`) |
| `selectTab(tab)` | `void` | Sets `activeTab` and emits `filterChanged` |

Renders 3 buttons: **All**, **Done**, **Not Done**. Active button gets an `.active` CSS class.

---

### `TaskList` — `src/app/components/task-list/`

**Selector:** `app-task-list`  
**Route:** `/tasks`

| Member | Type | Description |
|---|---|---|
| `apiService` | `TodoApi` | Injected todo service |
| `currentFilter` | `Signal<FilterType>` | Active filter state (default: `'all'`) |
| `filteredTodos` | `computed Signal<ToDo[]>` | Derived from `todos` signal + `currentFilter` |
| `ngOnInit()` | lifecycle | Loads todos from API scoped to logged-in user's email |
| `onFilterChange(filter)` | `void` | Updates `currentFilter` signal |

**Template:** Renders `<app-tabs>` for filtering, then loops over `filteredTodos()` using `@for`. Shows an empty state image (`EmptyTodos.png`) if no todos match the filter.

**Data flow on init:**
1. Read `user` from `localStorage` → parse email.
2. Reset `todos` signal to `[]`.
3. Call `getAllTodos(email)` → subscribe → set `todos` signal with API response.

---

### `Card` — `src/app/components/card/`

**Selector:** `app-card`

| Member | Type | Description |
|---|---|---|
| `toDo` | `@Input() ToDo` | The task object to display |
| `apiService` | `TodoApi` | Injected todo service |
| `toastService` | `ToastService` | Injected toast service |
| `showActions` | `boolean` | Controls action buttons visibility |
| `isEdited` | `boolean` | Toggles between view mode and edit mode |
| `editingTodo` | `ToDo` | Clone of `toDo` for in-place editing |
| `deleteCard()` | `void` | Calls API to delete, updates signal, shows 'delete' toast |
| `toggleDone()` | `void` | Flips `isSDone`, calls API update, updates signal, shows 'done' toast if marked done |
| `enableEdit()` | `void` | Creates a copy of `toDo` into `editingTodo`, sets `isEdited = true` |
| `cancelEdit()` | `void` | Sets `isEdited = false` (discards changes) |
| `saveEdit()` | `void` | Calls API update with `editingTodo`, updates signal, shows 'update' toast |

**View mode** shows: title, priority badge (color-coded), description, tags, date, done toggle button, edit/delete action buttons.  
**Edit mode** shows: inputs for title, description, priority select, date picker, Save and Cancel buttons.

**Priority color classes:**
- `.priority-high` — for `'High'` or `'Hard'`
- `.priority-medium` — for `'Medium'`
- `.priority-low` — for `'Low'`

> **Note:** Edit and Delete buttons are only shown when the task is **NOT** done (`!toDo.isSDone`).

---

### `TaskInput` — `src/app/components/task-input/`

**Selector:** `app-task-input`  
**Route:** `/add`

| Member | Type | Description |
|---|---|---|
| `apiService` | `TodoApi` | Injected todo service |
| `toastService` | `ToastService` | Injected toast service |
| `cdr` | `ChangeDetectorRef` | Used to force change detection after async form reset |
| `isSubmitted` | `boolean` | Flag that enables validation error display after submit attempt |
| `inputObj` | `ToDo` | The form model object, reset after successful submission |
| `addToArray()` | `void` | Validates, calls API to add todo, updates signal, shows 'success' toast |
| `resetForm()` | `ToDo` | Returns a blank ToDo object |

**Validation:** All five fields (title, description, priority, date, tags) are required. If any is empty and the user tries to submit, `isSubmitted = true` reveals error borders/messages. On success, the form is reset via `setTimeout` + `cdr.detectChanges()`.

**ID Generation:** Uses `uuid` v4, takes the first segment: `uuidv4().split('-')[0]`.

---

### `Toast` — `src/app/components/toast/`

**Selector:** `app-toast`

Reads `toastService.toastType()` signal and uses Angular's `@switch` block to render the correct toast message:

| Toast Type | Message |
|---|---|
| `success` | "Added successfully" |
| `delete` | "Deleted successfully" |
| `update` | "Updated successfully" |
| `done` | "Done!" |
| `nothing` | (nothing rendered) |

Each variant has a corresponding CSS class (`.success`, `.delete`, `.update`, `.done`) for color styling.

---

## 12. Pages

### `HomeDashboard` — `src/app/pages/home-dashboard/`

**Route:** `/home` (protected by `authGuard`)

- Renders `<app-gallary>` (auto-sliding image carousel).
- Shows 3 static summary cards: **Pending (12)**, **Critical (5)**, **Today (8)**.

---

### `Signin` — `src/app/pages/signin/`

**Route:** `/signin`  
**Form type:** Template-driven (`FormsModule`)

| Member | Type | Description |
|---|---|---|
| `showPassword` | `boolean` | Toggles password input type visibility |
| `router` | `Router` | Injected router |
| `apiServer` | `UserApi` | Injected user service |
| `authFailed` | `Signal<boolean>` | Alias for `apiServer.isLoggedIn` (used to show error) |
| `onSubmitClicked` | `boolean` | Enables error display after first submit attempt |
| `onSubmit(form, email, password)` | `void` | Validates credentials against API, sets `isLoggedIn`, navigates to `/home` |

**Authentication flow:**
1. Fetch all users from API.
2. Find a user matching the submitted email AND password.
3. If found: store user in `localStorage`, set `isLoggedIn.set(true)`, navigate to `/home`.
4. If not found: set `isLoggedIn.set(false)` (shows auth error message).

---

### `Signup` — `src/app/pages/signup/`

**Route:** `/signup`  
**Form type:** Reactive (`ReactiveFormsModule` + `FormGroup`)

| Member | Type | Description |
|---|---|---|
| `showPassword` | `boolean` | Toggles password visibility |
| `showConfirmPassword` | `boolean` | Toggles confirm password visibility |
| `apiServer` | `UserApi` | Injected user service |
| `router` | `Router` | Injected router |
| `form` | `FormGroup` | Reactive form with username, email, password, confirmpassword |
| `handleSubmit()` | `void` | Validates form, calls API to add user, navigates to `/home` |

**Custom Validator:** `matchPasswords` — a group-level validator that returns `{ missMatch: true }` if `password !== confirmpassword`.

**Field validations:**
- `username`: required
- `email`: required, valid email format
- `password`: required, min length 6
- `confirmpassword`: required, min length 6, must match `password`

**On success:** stores user in `localStorage`, sets `isLoggedIn.set(true)`, navigates to `/home`.

---

### `NotFound` — `src/app/pages/not-found/`

**Route:** `**` (wildcard catch-all)

Simple 404 page.

---

## 13. Component Interaction Diagram

```
App (root)
├── Header
│   ├── UserApi (isLoggedIn signal)
│   ├── Router (logout navigation)
│   └── Flame (streak icon, shown when logged in)
├── RouterOutlet
│   ├── HomeDashboard  [/home] ← authGuard
│   │   └── Gallary (auto-slide image carousel)
│   ├── Signin         [/signin]
│   │   └── UserApi (isUserExist, isLoggedIn)
│   ├── Signup         [/signup]
│   │   └── UserApi (addUser, isLoggedIn)
│   ├── TaskInput      [/add]  ← authGuard
│   │   ├── TodoApi (addTodo, todos signal)
│   │   └── ToastService (showToast 'success')
│   └── TaskList       [/tasks] ← authGuard
│       ├── TodoApi (getAllTodos, todos signal)
│       ├── TabsComponent ──(filterChanged)──► currentFilter signal
│       └── Card (×N)
│           ├── TodoApi (deleteTodo, updateTodo, todos signal)
│           └── ToastService (showToast 'delete'|'update'|'done')
├── Toast
│   └── ToastService (toastType signal)
└── Footer
```

### Signal Flow

```
UserApi.isLoggedIn (WritableSignal)
  ← set by: Signin.onSubmit(), Signup.handleSubmit(), Header.logout()
  → read by: Header (controls nav/auth buttons display)

TodoApi.todos (WritableSignal<ToDo[]>)
  ← set by: TaskList.ngOnInit() (initial load)
  ← updated by: Card.deleteCard(), Card.toggleDone(), Card.saveEdit(), TaskInput.addToArray()
  → computed by: TaskList.filteredTodos (filtered view of todos)
  → rendered by: TaskList → Card (×N)

ToastService.toastType (WritableSignal<ToastType>)
  ← set by: Card (delete/update/done), TaskInput (success)
  → read by: Toast component (renders correct message)
  → auto-reset to 'nothing' after 3000ms
```

---

## 14. Running the Project

### Prerequisites

- Node.js (LTS)
- npm ≥ 10.8.1
- Angular CLI ≥ 21

### Install dependencies

```bash
npm install
```

### Start JSON Server (mock API)

```bash
npx json-server db.json --port 3000
```

### Start Angular dev server

```bash
npm start
# App runs at: http://localhost:4200
```

### Default Test Users (from db.json)

| Username | Email | Password |
|---|---|---|
| essam | essam@gmail.com | 123456 |
| wdw | msam01619@gmail.com | dwdwddw |
| mo | mo@gmail.com | 123456 |

---

*Documentation generated: 2026-04-23*
