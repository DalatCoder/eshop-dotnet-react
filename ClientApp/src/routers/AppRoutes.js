import { About } from "../views/about";
import { Dashboard } from "../views/dashboard";

const AppRoutes = [
  {
    index: true,
    element: <Dashboard />,
  },
  {
    path: "/about",
    element: <About />,
  },
];

export default AppRoutes;
