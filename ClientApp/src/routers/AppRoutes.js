import { About } from "../views/about";
import CategoryView from "../views/category";
import { Dashboard } from "../views/dashboard";

const AppRoutes = [
  {
    index: true,
    element: <Dashboard />,
  },
  {
    path: "/admin/categories",
    element: <CategoryView />,
  },
  {
    path: "/admin/about",
    element: <About />,
  },
];

export default AppRoutes;
