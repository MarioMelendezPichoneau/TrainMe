import { Header } from "../layout/Header";
import { Hero } from "../common/Hero";
import { ContentHomePage } from "../common/ContentHomePage";
import { Announcement } from "../common/Announcement";

export const HomePage = () => {
  return (
    <>
      <Announcement />
      <Header />
      <ContentHomePage />
    </>
  );
};
