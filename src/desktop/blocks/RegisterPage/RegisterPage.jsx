import React from "react";

import styles from "./style.module.scss";

const RegisterPage = () => {
  return (
    <div className={styles.background}>
      <div className={styles.title}>Register to Sekhmet</div>
        <div className={styles.container}>
            <label className={styles.labelStyle}>Name</label>
            <input className={styles.inputStyle}></input>
            <label className={styles.labelStyle}>Username</label>
            <input className={styles.inputStyle}></input>
            <label className={styles.labelStyle}>Email address</label>
            <input className={styles.inputStyle}></input>
            <label className={styles.labelStyle}>Password</label>
            <input className={styles.inputStyle}></input>
            <label className={styles.labelStyle}>Confirm Password</label>
            <input className={styles.inputStyle}></input>
            <button className={styles.signInButton}>Sign in</button>
            <p className={styles.alreadyText}>Already have an account? <a className={styles.alreadyLink} href="/">Sign in.</a></p>
        </div>
    </div>
  );
};

export default RegisterPage;
