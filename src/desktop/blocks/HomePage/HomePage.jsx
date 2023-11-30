import React from "react";

import bellImg from "../../../core/assets/icons/Bell.svg";
import searchIconImg from "../../../core/assets/icons/SearchIcon.svg";

import styles from "./style.module.scss";

const HomePage = () => {
  return (
    <>
      <div className={styles.containerNavBar}>
        <div className={styles.wrapStart}>
          <div className={styles.burger}>
            <div className={styles.line}></div>
            <div className={styles.line}></div>
            <div className={styles.line}></div>
          </div>
          <p className={styles.title}>Sekhmet</p>
        </div>
        <div className={styles.searchBar}>
          <input className={styles.inputSearchBar}></input>
          <button className={styles.searchButton}>
            <img
              className={styles.searchIconImg}
              src={searchIconImg}
              alt="Bell notification icon"
            />
          </button>
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
          <p className={styles.filterText2}>Explore</p>
        </div>
        <div className={styles.filterUnderLine} />
        <button className={styles.createButton}>Create</button>
      </div>
    </>
  );
};

export default HomePage;
