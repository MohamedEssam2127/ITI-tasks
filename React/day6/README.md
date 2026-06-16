# TechPulse 🚀

TechPulse is a modern, high-performance news application built with React, Redux Toolkit, and Vite. It features a stunning glassmorphism design, full multi-language support (English & Arabic), and a responsive layout that adapts perfectly to any device.

## ✨ Features

-   **Stunning UI/UX**: Premium glassmorphism design with animated backgrounds and smooth transitions.
-   **Multi-language (i18n)**: Full support for English and Arabic with automatic Right-to-Left (RTL) layout switching.
-   **Dark & Light Modes**: Seamless theme switching with a modern dark mode implementation.
-   **Featured News Slider**: Interactive slider showcasing top stories with a sleek overlay.
-   **Advanced Search**: Live news filtering by title, category, or content.
-   **Auth System**: Secure Login and Signup pages with animated validation and premium aesthetics.
-   **News Management**: Ability to add new stories (for authenticated users).
-   **Detailed News View**: Rich details page with metadata (category, time) and high-quality image presentation.
-   **Global State Management**: Powered by Redux Toolkit for efficient data handling.
-   **Responsive Design**: Fully optimized for mobile, tablet, and desktop screens.

## 🛠️ Tech Stack

-   **Core**: [React 19](https://react.dev/)
-   **State Management**: [Redux Toolkit](https://redux-toolkit.js.org/)
-   **Routing**: [React Router 7](https://reactrouter.com/)
-   **Styling**: Vanilla CSS (CSS Modules)
-   **Icons**: [React Icons](https://react-icons.github.io/react-icons/) & FontAwesome
-   **API Handling**: [Axios](https://axios-http.com/)
-   **Internationalization**: [i18next](https://www.i18next.com/)
-   **Notifications**: [React Hot Toast](https://react-hot-toast.com/)
-   **Build Tool**: [Vite](https://vitejs.dev/)

## 🚀 Getting Started

### Prerequisites

-   Node.js (v18.0.0 or higher)
-   npm or yarn

### Installation

1.  **Clone the repository**:
    ```bash
    git clone <repository-url>
    ```

2.  **Navigate to the project directory**:
    ```bash
    cd tech-news-app
    ```

3.  **Install dependencies**:
    ```bash
    npm install
    ```

4.  **Run the JSON Server** (Mock Database):
    Ensure you have `json-server` installed globally or run it using npx:
    ```bash
    npx json-server --watch db.json --port 3000
    ```

5.  **Start the development server**:
    ```bash
    npm run dev
    ```

The application will be available at `http://localhost:5173` (or the port specified in your terminal).

## 📁 Project Structure

```text
src/
├── assets/             # Images and static assets
├── components/         # Reusable UI components (Header, Footer, Card, etc.)
├── Context/            # React Context providers
├── localization/       # translation files (en, ar)
├── pages/              # Main page components (Home, Login, NewsDetails, etc.)
├── Redux/              # Redux slices and store configuration
├── styles/             # CSS modules and global styles
├── App.jsx             # Main application component
├── main.jsx            # Entry point
└── i18n.js             # Internationalization configuration
```

