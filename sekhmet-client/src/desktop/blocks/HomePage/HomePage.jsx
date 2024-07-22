import React from "react";

import bellImg from "../../../core/assets/icons/NotificationsIcon.svg";
import searchIconImg from "../../../core/assets/icons/SearchIcon.svg";
import messageCircle from "../../../core/assets/icons/MessageIcon.svg";

import styles from "./style.module.scss";
import VideoPost from "../../components/VideoPost";

const HomePage = () => {
  return (
    <>
      <div className={styles.containerNavBar}>
        <div className={styles.wrapStart}>
        <img
            className={styles.bell}
            src={messageCircle}
            alt="Message notification icon"
          />
          <p className={styles.title}>Sekhmet</p>
        </div>
        <div className={styles.searchBar}>
          <input className={styles.inputSearchBar}></input>
          <div className={styles.searchButton}>
            <img
              className={styles.searchIconImg}
              src={searchIconImg}
              alt="Bell notification icon"
            />
          </div>
        </div>
        <div className={styles.wrapEnd}>
          <img
            className={styles.bell}
            src={bellImg}
            alt="Bell notification icon"
          />
          <a href="/profile"><div className={styles.profileIcon}></div></a>
        </div>
      </div>
      <div className={styles.content}>
        <div className={styles.filterOption}>
          <p className={styles.filterText1}>Following</p>
          <p className={styles.filterText2}>Story</p>
          <p className={styles.filterText2}>Explore</p>
        </div>
        <div className={styles.filterUnderLine} />
      </div>
      <VideoPost />
      <VideoPost />
      <VideoPost />
      <VideoPost />
    </>
  );
};

export default HomePage;
