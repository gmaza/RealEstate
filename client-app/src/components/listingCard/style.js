import styled from 'styled-components';
import { Button } from '@material-ui/core';

export const Container = styled.div`
    position: relative;
    background: #ffffff;
    border: 1px solid #e8e8e8;
    box-shadow: 0px 3px 11px rgba(0, 0, 0, 0.13);
    border-radius: 5px;
    width: 100%;
`;

export const Slide = styled.div`
    height: 172px;
    width: 100%;
    background-color: #000;
    color: #fff;
    img {
        height: 100%;
        width: 100%;
        object-fit: cover;
    }
`;

export const DetailsContainer = styled.div`
    padding: 16px;
`;

export const Title = styled.div`
    font-style: normal;
    font-weight: 500;
    font-size: 16px;
    line-height: 23px;
`;

export const Price = styled.div`
    margin: 10px 0;
    font-style: normal;
    font-weight: bold;
    font-size: 18px;
    line-height: 18px;

    color: ${(props) =>
        props.variant === 'vip'
            ? '#f8655e'
            : props.variant === 'hot'
            ? '#F68C1E'
            : '#004DFF'};
`;

export const TagsContainer = styled.div`
    display: flex;
    flex-direction: row;
`;

export const Tag = styled.div`
    display: flex;
    flex-direction: row;
    align-items: center;
    background: ${(props) =>
        props.variant === 'vip'
            ? '#fff0ef'
            : props.variant === 'hot'
            ? '#fff4e9'
            : '#e6eeff'};
    border-radius: 5px;
    margin-right: 10px;
    height: 30px;
    padding: 8px 10px;
    font-style: normal;
    font-weight: 500;
    font-size: 11px;
    line-height: 11px;

    color: #404040;
    span {
        margin-left: 5px;
        white-space: nowrap;
    }
    .MuiSvgIcon-root {
        width: 0.75rem;
        height: 0.75rem;
        color: ${(props) =>
            props.variant === 'vip'
                ? '#f8655e'
                : props.variant === 'hot'
                ? '#F68C1E'
                : '#004DFF'};
    }
`;

const SwiperButton = styled.div`
    position: absolute;
    top: 66px;
    display: flex;
    align-items: center;
    justify-content: center;
    z-index: 5;
    background: rgba(64, 64, 64, 0.7);
    width: 20px;
    height: 40px;
    cursor: pointer;
`;

export const SwiperButtonPrev = styled(SwiperButton)`
    border-bottom-right-radius: 40px;
    border-top-right-radius: 40px;
    left: 0;
`;

export const SwiperButtonNext = styled(SwiperButton)`
    border-bottom-left-radius: 40px;
    border-top-left-radius: 40px;
    right: 0;
`;
