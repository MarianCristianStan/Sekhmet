import React, { useState, useEffect } from "react";
import { isDesktop, isTablet } from "react-device-detect";
import { BrowserRouter, Routes, Route } from "react-router-dom";

import SignInPage from "../../desktop/blocks/SignInPage/SignInPage";
import RegisterPage from "../../desktop/blocks/RegisterPage/RegisterPage";

const renderRouter = (platform) => {
  if (platform === "desktop" && isDesktop)
    return (
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<SignInPage />} />
          <Route path="/register" element={<RegisterPage />} />
        </Routes>
      </BrowserRouter>
    );
  else if (platform === "tablet" || isTablet)
    return (
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<SignInPage />} />
          <Route path="/register" element={<RegisterPage />} />
        </Routes>
      </BrowserRouter>
    );
  else return (
    <BrowserRouter>
        <Routes>
          <Route path="/" element={<SignInPage />} />
          <Route path="/register" element={<RegisterPage />} />
        </Routes>
      </BrowserRouter>
  );
};

const Navigation = () => {
  const [platform, setPlatform] = useState("desktop");

  useEffect(() => {
    function handleResize() {
      if (window.innerWidth < 992 && window.innerWidth > 576) setPlatform("tablet");
      else if (window.innerWidth < 576) setPlatform("mobile");
      else if (window.innerWidth > 992) setPlatform("desktop");
    }

    window.addEventListener("resize", handleResize);
  }, []);

  return <div>{renderRouter(platform)}</div>;
};

export default Navigation;