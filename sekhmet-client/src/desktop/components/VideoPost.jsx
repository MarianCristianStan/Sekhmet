import React, { useState, useRef } from "react";

import styles from "./style.module.scss";

import videoTest from "../../core/assets/temporaryVideos/dorul.mp4";

const VideoPost = () => {
  const [isPlaying, setIsPlaying] = useState(false);
  const videoRef = useRef(null);

  const togglePlay = () => {
    if (videoRef.current.paused) {
      videoRef.current.play();
    } else {
      videoRef.current.pause();
    }
    setIsPlaying(!isPlaying);
  };

  return (
    <div className={styles.container}>
      <div className={styles.videoContent}>
        <div className={styles.videoContainer}>
          <video
            className={styles.videoStyling}
            src={videoTest}
            ref={videoRef}
            controls
            autoPlay={false}
            loop={false}
            muted={false}
            onPlay={() => setIsPlaying(true)}
            onPause={() => setIsPlaying(false)}
          />
        </div>
        <div className={styles.buttonContainer}>
        <button className={styles.buttonStyling} onClick={togglePlay}>{isPlaying ? "Pause" : "Play"}</button>
        </div>
      </div>
      <div className={styles.descriptionText}>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
        tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
        veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
        commodo consequat. Duis aute irure dolor in reprehenderit in voluptate
        velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint
        occaecat cupidatat non proident, sunt in culpa qui officia deserunt
        mollit anim id est laborum.
      </div>
    </div>
  );
};

export default VideoPost;
