import React from "react";

import styles from "./style.module.scss";

const SignInPage = () => {
  return (
    <div className={styles.background}>
      <div className={styles.title}>Sign in to Sekhmet</div>
        <div className={styles.container}>
            <label className={styles.labelStyle}>Username</label>
            <input className={styles.inputStyle}></input>
            <div className={styles.passwordLabel}>
            <label className={styles.labelStyle}>Password</label>
            <label className={styles.forgotPassword}>Forgot password?</label>
            </div>
            <input className={styles.inputStyle}></input>
            <button className={styles.signInButton}>Sign in</button>
            <p className={styles.alreadyText}>Need an account? <a className={styles.alreadyLink} href="/register">Sign up</a></p>
        </div>
    </div>
  );
};

export default SignInPage;
