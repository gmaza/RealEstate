import React, { useRef } from 'react';
import {
    Container,
    Slide,
    Title,
    DetailsContainer,
    Price,
    TagsContainer,
    Tag,
    SwiperButtonPrev,
    SwiperButtonNext,
} from './style';
import { Swiper, SwiperSlide } from 'swiper/react';
import 'swiper/swiper.scss';
import {
    PropertyLayoutIcon,
    AreaIcon,
    PropertyTypeIcon,
    LeftArrowIcon,
    RightArrowIcon,
} from '../icons';

export const ListingCard = (props) => {
    const ref = useRef(null);

    const goPrev = () => {
        if (ref.current !== null && ref.current.swiper !== null) {
            ref.current.swiper.slidePrev();
        }
    };

    const goNext = () => {
        if (ref.current !== null && ref.current.swiper !== null) {
            ref.current.swiper.slideNext();
        }
    };

    return (
        <Container>
            <Swiper ref={ref}>
                <SwiperSlide>
                    <Slide>
                        <img
                            src="https://www.bezrealitky.cz/media/cache/record_main/data/record/images/617k/617051/1594659255-yjveiwprzc.jpg"
                            alt=""
                        />
                    </Slide>
                </SwiperSlide>
                <SwiperSlide>
                    <Slide>
                        <img
                            src="https://www.bezrealitky.cz/media/cache/record_main/data/record/images/617k/617051/1594659255-yjveiwprzc.jpg"
                            alt=""
                        />
                    </Slide>
                </SwiperSlide>
                <SwiperSlide>
                    <Slide>
                        <img
                            src="https://www.bezrealitky.cz/media/cache/record_main/data/record/images/617k/617051/1594659255-yjveiwprzc.jpg"
                            alt=""
                        />
                    </Slide>
                </SwiperSlide>
                <SwiperSlide>
                    <Slide>
                        <img
                            src="https://www.bezrealitky.cz/media/cache/record_main/data/record/images/617k/617051/1594659255-yjveiwprzc.jpg"
                            alt=""
                        />
                    </Slide>
                </SwiperSlide>
                <SwiperSlide>
                    <Slide>
                        <img
                            src="https://www.bezrealitky.cz/media/cache/record_main/data/record/images/617k/617051/1594659255-yjveiwprzc.jpg"
                            alt=""
                        />
                    </Slide>
                </SwiperSlide>
            </Swiper>

            <SwiperButtonPrev onClick={goPrev}>
                <LeftArrowIcon />
            </SwiperButtonPrev>
            <SwiperButtonNext onClick={goNext}>
                <RightArrowIcon />
            </SwiperButtonNext>

            <DetailsContainer>
                <Title>
                    8430 Reading Ave, Los Angeles, CA 90045 Brandon Mill
                    Subdivision
                </Title>

                <Price variant={props.variant}>$ 187,000</Price>

                <TagsContainer>
                    <Tag variant={props.variant}>
                        <PropertyLayoutIcon /> <span>1 + kk</span>
                    </Tag>
                    <Tag variant={props.variant}>
                        <PropertyTypeIcon />
                        <span>Flat</span>
                    </Tag>
                    <Tag variant={props.variant}>
                        <AreaIcon />
                        <span>
                            451m<sup>2</sup>
                        </span>
                    </Tag>
                </TagsContainer>
            </DetailsContainer>
        </Container>
    );
};
