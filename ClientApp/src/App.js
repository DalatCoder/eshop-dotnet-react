import React from "react";
import { Route, Routes } from "react-router-dom";
import AppRoutes from "./routers/AppRoutes";
import AdminLayout from "./layouts/Layout";

const App = () => {
  return (
    <AdminLayout>
      <Routes>
        {AppRoutes.map((route, index) => {
          const { element, ...rest } = route;
          return <Route key={index} {...rest} element={element} />;
        })}
      </Routes>
    </AdminLayout>
  );
};

export default App;
