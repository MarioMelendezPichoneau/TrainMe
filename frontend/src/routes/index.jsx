import { BrowserRouter, Route, Routes } from "react-router-dom";
import { HomePage } from "../components/pages/HomePage";
import { LoginPage } from "../components/pages/LoginPage";
import { SingupPage } from "../components/pages/SingupPage";
import { TrainerSearchPage } from "../components/pages/TrainerSearchPage";

const AppRouter = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route index path="/" Component={HomePage} />
        <Route path="/login" Component={LoginPage} />
        <Route path="/register" Component={SingupPage} />
        <Route path="/trainers" Component={TrainerSearchPage} />
      </Routes>
    </BrowserRouter>
  );
};

export default AppRouter;
