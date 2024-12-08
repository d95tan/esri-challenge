# React Native App

This is a React Native mobile application that displays a map centered at a specific location using the ArcGIS Maps SDK. It shows a blue point symbol at the given location.

## Setup

1. Clone the repo and navigate to question-2:

   ```bash
   cd question 2
   ```
2. Install dependencies:

   ```bash
   npm install
   ```
3. Run the project:

   ```bash
   # For android
   npm run android

   # For iOS
   npm run ios
   ```

## Dev Notes

#### `App.js` (Main Component)

This file initializes the React Native app, loads the map, and sets up the ArcGIS view with the specified location and marker.

The ArcGIS map is displayed using a `<WebView>` component (essentially a HTML) in App.js.

Due to time constraints, I decided to use React Native instead of Flutter/Kotlin/Swift due to my prior experience, even though ArcGIS does not directly support React Native. For a simple app just for displaying a static map, using React Native with WebView is sufficient. However, for more complex applications, using a framework supported by ArcGIS would be more advisable.
